using Comparison_Engine.Base_Classes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comparison_Engine.GoogleMap
{
    public sealed class MapController
    {
        private static readonly Lazy<MapController>
            lazy = new Lazy<MapController>(() => new MapController());

        public static MapController Instance { get { return lazy.Value; } }

        private MapController()
        {

        }

        // set default values so it would compile, but will need to set these depending on user or from current location
        public double prefDistance { get; set; } = 69; // user's preferred distance to a bar
        public string homeAddress { get; set; } = "S. Nėries 99"; // user's current location (for now home location until we can just get current location)
        public bool prefWalking { get; set; } = true; // user's preference to walk/drive

        // Initializes map and provides all necessities
        public void InitMap(GMapControl map, int zoomAtLoad = 16)
        {
            GMapProviders.GoogleMap.ApiKey = File.ReadAllText("API_KEY.txt");
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = "MapsCache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;

            map.MinZoom = 3; // Minimum zoom level
            map.MaxZoom = 18; // Maximum zoom level
            SetZoom(map, zoomAtLoad);

            ShowHome(map);
        }

        private void ShowHome(GMapControl map)
        {
            ShowMapByAddress(map, homeAddress);
        }

        // removes all current overlays
        public void RemoveOverlays(GMapControl map)
        {
            if (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(0);
                map.Refresh();
            }
        }

        // puts markers on all bars within a wanted radius which have a specific drink and notes it's price in those bars
        //might need to adjust map by zooming out in the future
        public void ShowBarsWithDrink(GMapControl map, Drink specificDrink, Dictionary<int, Bar> barDictionary)
        {
            DrinkManager drinkManager = DrinkManager.Instance;
            var cheapestPlaces = drinkManager.FindLowestPrice(specificDrink.drinkID).Item2;

            var barIDs = drinkManager.FindAllBarsWithDrink(specificDrink.drinkID);//.Keys.ToArray(); // maybe could rewrite with FindAllBarsWithDrink

            foreach (KeyValuePair<int, float> barAndPrice in barIDs)
            {
                var bar = barDictionary[barAndPrice.Key];

                if (cheapestPlaces.Contains(barAndPrice.Key))
                {
                    MarkBarInRadius(map, bar, $"{bar.barName} \n {bar.barLocation} \n {barAndPrice.Value}", GMarkerGoogleType.orange_small);
                }
                else
                {
                    MarkBarInRadius(map, bar, $"{bar.barName} \n {bar.barLocation} \n {barAndPrice.Value}");
                }
            }

            ShowHome(map);
        }

        //puts markers on all bars within a users specified radius with addresses, names and distance to them
        //might need to adjust map by zooming out in the future
        public void ShowNearBars(GMapControl map, List<Bar> barList)
        {
            foreach (Bar bar in barList)
            {
                MarkBarInRadius(map, bar, $"{bar.barName} \n {bar.barLocation}");
            }

            ShowHome(map);
        }

        private void MarkBarInRadius(GMapControl map, Bar bar, string markerString, GMarkerGoogleType markerType = GMarkerGoogleType.black_small)
        {
            var distanceTo = GetDistance(homeAddress, bar.barLocation);

            if (distanceTo <= prefDistance)
            {
                ShowMapByAddress(map, bar.barLocation, markerString + $"\n {distanceTo}", markerType);
            }
        }

        // positions map on the given address location
        public void ShowMapByAddress(GMapControl map, string address)
        {
            var point = GetPointFromAddress(address);
            ShowMapToPoint(map, point);
        }

        public void ShowMapByAddress(GMapControl map, string address, string toolTipText, GMarkerGoogleType markerType = GMarkerGoogleType.black_small)
        {
            var point = GetPointFromAddress(address);
            ShowMapToPoint(map, point, toolTipText, markerType);
        }

        // positions map on the given keyword location
        public void ShowMapByKeyword(GMapControl map, string keywords, string toolTipText)
        {
            map.SetPositionByKeywords(keywords);
            PointLatLng point = new PointLatLng(map.Position.Lat, map.Position.Lng);
            AddMarkerWithTooltip(map, point, toolTipText);
        }

        public void ShowRoute(GMapControl map, string addressWhereTo)
        {
            if (prefWalking)
            {
                ShowRouteTo(map, addressWhereTo, avoidHighways: true, walkingMode: true);
            }
            else
            {
                ShowRouteTo(map, addressWhereTo, avoidHighways: false, walkingMode: false);
            }
        }
        // displays route between two addresses
        public void ShowRouteTo(GMapControl map, string addressWhereTo, string routeName = "New Route", string overlayName = "New Overlay", bool avoidHighways = false, bool walkingMode = true)
        {
            var pointA = GetPointFromAddress(homeAddress);
            var pointB = GetPointFromAddress(addressWhereTo);

            var route = GoogleMapProvider.Instance.GetRoute(pointA, pointB, avoidHighways, walkingMode, 14);

            var r = new GMapRoute(route.Points, routeName)
            {
                Stroke = new Pen(Color.Red, 3)
            };

            var routes = new GMapOverlay(overlayName);
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            RefreshMap(map);
        }

        // gets distance between two addresses
        public int GetDistance(string addressA, string addressB)
        {
            var pointA = GetPointFromAddress(addressA);
            var pointB = GetPointFromAddress(addressB);

            return (int)GoogleMapProvider.Instance.GetRoute(pointA, pointB, false, true, 14).Distance;
        }

        private PointLatLng GetPointFromAddress(string address)
        {
            GeoCoderStatusCode statusCode;
            var addressPoint = GoogleMapProvider.Instance.GetPoint(address.Trim(), out statusCode);

            if (statusCode == GeoCoderStatusCode.OK)
            {
                return (PointLatLng)addressPoint;
            }
            else
            {
                throw new Exception($"Failed to get an address, status code: {statusCode}");
            }
        }

        private void ShowMapToPoint(GMapControl map, PointLatLng point)
        {
            map.Position = point;
        }

        private void ShowMapToPoint(GMapControl map, PointLatLng point, string toolTipText, GMarkerGoogleType markerType = GMarkerGoogleType.black_small)
        {
            ShowMapToPoint(map, point);
            AddMarkerWithTooltip(map, point, toolTipText, markerType);
        }

        private void AddMarkerWithTooltip(GMapControl map, PointLatLng point, string toolTipText, GMarkerGoogleType markerType = GMarkerGoogleType.black_small)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, markerType)
            {
                ToolTipText = toolTipText
            };

            var toolTip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.Transparent),
                Foreground = new SolidBrush(Color.Black),
                Offset = new Point(8, -20),
                Stroke = new Pen(new SolidBrush(Color.White))
            };
            marker.ToolTip = toolTip;
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        // this refreshes map when drawing polygons or routes
        private void RefreshMap(GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }

        // sets zoom level
        private void SetZoom(GMapControl map, int zoom)
        {
            map.Zoom = zoom;
        }
    }
}
