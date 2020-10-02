using Comparison_Engine.Base_Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace Comparison_Engine
{
    class Data
    {

        public static List<Bar> GetBars()
        {
            StreamReader r = new StreamReader("barInput.json");
            string json = r.ReadToEnd();
            List<Bar> bars = JsonConvert.DeserializeObject<List<Bar>>(json);
            return bars;
        }

        public static List<Drink> GetDrinks()
        {
            StreamReader r = new StreamReader("drinkInput.json");
            string json = r.ReadToEnd();
            List<Drink> drinks = JsonConvert.DeserializeObject<List<Drink>>(json);
            return drinks;
        }

    }
}
