using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            map.Zoom = zoomAtLoad; // Current zoom position
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

        // positions map on the given address location
        public void ShowMapByAddress(GMapControl map, string address, string toolTipText)
        {
            var point = GetPointFromAddress(address);
            ShowMapToPoint(map, point, toolTipText);
        }

        // positions map on the given keyword location
        public void ShowMapByKeyword(GMapControl map, string keywords, string toolTipText)
        {
            map.SetPositionByKeywords(keywords);
            PointLatLng point = new PointLatLng(map.Position.Lat, map.Position.Lng);
            AddMarkerWithTooltip(map, point, toolTipText);
        }

        // displays route between two addresses
        public void ShowRoute(GMapControl map, string addressA, string addressB, string routeName, string overlayName, bool avoidHighways, bool walkingMode)
        {
            var pointA = GetPointFromAddress(addressA);
            var pointB = GetPointFromAddress(addressB);

            var route = GoogleMapProvider.Instance.GetRoute(pointA, pointB, avoidHighways, walkingMode, 14);

            var r = new GMapRoute(route.Points, routeName)
            {
                Stroke = new Pen(Color.AliceBlue, 3)
            };

            var routes = new GMapOverlay(overlayName);
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            RefreshMap(map);
        }

        // gets distance between two addresses
        public double GetDistance(string addressA, string addressB)
        {
            var pointA = GetPointFromAddress(addressA);
            var pointB = GetPointFromAddress(addressB);

            return GoogleMapProvider.Instance.GetRoute(pointA, pointB, false, true, 14).Distance;
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

        private void ShowMapToPoint(GMapControl map, PointLatLng point, string toolTipText)
        {
            map.Position = point;
            AddMarkerWithTooltip(map, point, toolTipText);
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
    }
}
