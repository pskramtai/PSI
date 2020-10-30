using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Comparison_Engine.Form_Classes
{
    class ButtonListMethods
    {


        //BAR BUTTON FUNCTIONS
        public static void CreateBarButton(Bar bar, Form1 mainApplication)
        {
            Button button = new Button();
            ConfigureBarButton(button, bar, mainApplication);
            BindBar(button, bar, mainApplication);
        }

        private static void BindBar(Button button, Bar bar, Form1 mainApplication)
        {
            button.Click += (sender, EventArgs) => { BarButtonClick(bar, mainApplication); };
        }

        private static void BarButtonClick(Bar bar, Form1 mainApplication)
        {
            ChildFormMethods.OpenChildFormBar(bar, mainApplication);
            mainApplication.mapController.RemoveOverlays(mainApplication.map);
            mainApplication.mapController.ShowRoute(mainApplication.map, bar.barLocation);
        }
        private static void ConfigureBarButton(Button button, Bar bar, Form1 mainApplication)
        {
            mainApplication.panelSubList.Controls.Add(button);
            button.Text = (bar.barName);
            button.Dock = DockStyle.Top;
        }



        //DRINK BUTTON FUNCTIONS
        public static void CreateDrinkButton(Drink drink, Form1 mainApplication)
        {
            Button button = new Button();
            ButtonListMethods.ConfigureDrinkButton(button, drink, mainApplication);
            BindDrink(button, drink, mainApplication);
        }

        private static void BindDrink(Button button, Drink drink, Form1 mainApplication)
        {
            button.Click += (sender, EventArgs) => { ButtonListMethods.DrinkButtonClick(drink, mainApplication); };
        }


        public static void DrinkButtonClick(Drink drink, Form1 mainApplication)
        {
            ChildFormMethods.OpenChildFormDrink(drink, mainApplication);
            mainApplication.mapController.RemoveOverlays(mainApplication.map);
            mainApplication.mapController.ShowBarsWithDrink(mainApplication.map, drink, mainApplication.barManager.barDictionary);
        }
        public static void ConfigureDrinkButton(Button button, Drink drink, Form1 mainApplication)
        {
            mainApplication.panelSubList.Controls.Add(button);
            button.Text = (drink.drinkName);
            button.Dock = DockStyle.Top;
        }




        public static void ClearButtonList(Form1 mainApplication)
        {
            mainApplication.panelSubList.Controls.Clear();
        }
    }
}
