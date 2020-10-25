using Comparison_Engine.Base_Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows;

namespace Comparison_Engine
{
    class Data
    {

        public static Dictionary<int, Bar> GetBars()
        {
            Dictionary<int, Bar> bars;

            try
            {
                using (StreamReader r = new StreamReader("barInput.json"))
                {
                    string json = r.ReadToEnd();
                    bars = JsonConvert.DeserializeObject<Dictionary<int, Bar>>(json);
                }
                return bars;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return null;
                
            }
            
        }

        public static Dictionary<int, Drink> GetDrinks()
        {
            Dictionary<int, Drink> drinks;

            try
            {
                using (StreamReader r = new StreamReader("drinkInput.json"))
                {
                    string json = r.ReadToEnd();
                    drinks = JsonConvert.DeserializeObject<Dictionary<int, Drink>>(json);
                }
                return drinks;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return null;
            }
            
        }

        public static void SaveBars(Dictionary<int, Bar> bars)
        {
            try
            {
                File.WriteAllText("barInput.json", JsonConvert.SerializeObject(bars, Formatting.Indented));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void SaveDrinks(Dictionary<int, Drink> drinks)
        {
            try
            {
                File.WriteAllText("drinkInput.json", JsonConvert.SerializeObject(drinks, Formatting.Indented));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
