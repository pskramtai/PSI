using Comparison_Engine.Base_Classes;
using System.Collections.Generic;

namespace Comparison_Engine.Form_Classes
{
    class ListMethods
    {
        public static void StateCheck(Form1 maipApplication)
        {
            if (maipApplication.barsIsTop)
            {
                LoadBars(maipApplication.barManager.barDictionary, maipApplication);
                ButtonBarsIsTop(maipApplication);

            }
            else
            {
                LoadDrinks(maipApplication.drinkManager.drinkDictionary, maipApplication);
                ButtonDrinksIsTop(maipApplication);

            }
        }

        public static void ButtonDrinksIsTop(Form1 maipApplication)
        {
            maipApplication.buttonTop.Text = "Drinks";
            maipApplication.buttonBottom.Text = "Bars";
        }

        public static void ButtonBarsIsTop(Form1 maipApplication)
        {
            maipApplication.buttonTop.Text = "Bars";
            maipApplication.buttonBottom.Text = "Drinks";
        }

        public static void LoadBars(Dictionary<int, Bar> barsDictionary, Form1 mainApplication)
        {
            ButtonListMethods.ClearButtonList(mainApplication);
            foreach (Bar bar in barsDictionary.Values)
            {
                ButtonListMethods.CreateBarButton(bar, mainApplication);
            }
        }

        public static void LoadDrinks(Dictionary<int, Drink> drinksDictionary, Form1 mainApplication)
        {
            ButtonListMethods.ClearButtonList(mainApplication);
            foreach (Drink drink in drinksDictionary.Values)
            {
                ButtonListMethods.CreateDrinkButton(drink, mainApplication);
            }
        }
    }
}
