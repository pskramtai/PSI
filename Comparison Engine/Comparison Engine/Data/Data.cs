using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Comparison_Engine
{
    class Data
    {

        public static List<Bar> GetBars()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"testDataBars.txt");
            string[] lines = File.ReadAllLines(filePath);
            if (lines == null || lines.Length == 0) return null;

            List<Bar> barList = new List<Bar>();
            int barId;
            string barName;
            string barLocation;

            int drinkId;
            float drinkPrice;

            foreach(string line in lines)
            {
                //Splitting line into pieces to build bar object. First 3 pieces are ID, name and location.

                string[] pieces = line.Split(',');
                barId = Int32.Parse(pieces[0]);
                barName = pieces[1];
                barLocation = pieces[2];

                Bar bar = new Bar(barId, barName, barLocation);

                //the remaining pieces are drink IDs and prices in pairs.

                for(int i=3; i<pieces.Length; i += 2)
                {
                    drinkId = Int32.Parse(pieces[i]);
                    drinkPrice = float.Parse(pieces[i + 1]);
                    bar.AddDrink(drinkId, drinkPrice);
                }
                barList.Add(bar);
            }
            return barList;
        }

    }
}
