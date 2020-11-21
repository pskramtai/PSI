using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Comparison_Engine.Child_Forms
{
    public partial class UserContribution : Form
    {
        private DrinkManager drinkManager = DrinkManager.Instance;
        private BarManager barManager = BarManager.Instance;

        public UserContribution()
        {
            Dictionary<int, float> barChoices = new Dictionary<int, float>();
            InitializeComponent();
            PopulateComboBoxBar();
            PopulateComboBoxDrink();
            comboBoxBar.SelectedIndexChanged += new EventHandler(ComboBoxBarSelectionChange);
        }

        private void ComboBoxBarSelectionChange(object sender, EventArgs e)
        {
            var selectedBar = (Bar)comboBoxBar.SelectedItem;
            List<Drink> drinklist = new List<Drink>();

            foreach (var drink in selectedBar.availableDrinks)
            {
                drinklist.Add(drinkManager.GetDrinkByID(drink.Key));
            }

            comboBoxDrink.DataSource = new BindingSource(drinklist, null);
        }

        private void ButtonAddDrink_Click(object sender, EventArgs e)
        {
            if (textBoxDrink.Text == "" || comboBoxBar2.SelectedItem == null || textBoxPrice2.Text == "")
            {
                MessageBox.Show("Bad input");
                return;
            }

            Bar bar = ((Bar)comboBoxBar2.SelectedItem);
            string drinkName = textBoxDrink.Text;

            if (Regex.IsMatch(textBoxPrice2.Text, @"(^[1-9]\d*(.\d{1,2})?$)|(^0(\.\d{1,2})?$)"))
            {
                float price = (float)Convert.ToDouble(textBoxPrice2.Text);

                if (drinkManager.GetDrinkByName(drinkName) == null)
                {
                    drinkManager.AddDrink(drinkName);
                }

                Drink drink = drinkManager.GetDrinkByName(drinkName);

                if (barManager.GetBarByID(bar.barID).availableDrinks.ContainsKey(drink.drinkID))
                {
                    MessageBox.Show("Drink with this name already exists in this bar");
                    return;
                }

                barManager.GetBarByID(bar.barID).AddDrink(drink.drinkID, price);
                drink.AddBar(bar.barID, price);
            }

            textBoxDrink.Text = "";
            textBoxPrice2.Text = "";
            PopulateComboBoxBar();
        }

        private void ButtonAddBar_Click(object sender, EventArgs e)
        {
            string BarName = textBoxBarName.Text;
            string BarAdress = textBoxBarAdress.Text;

            if (BarName == "" || BarAdress == "" || BarName == null || BarAdress == null)
            {
                MessageBox.Show("Bad input");
                return;
            }

            if (barManager.GetBarByName(BarName) != null)
            {
                textBoxBarName.Text = "";
                textBoxBarAdress.Text = "";
                MessageBox.Show("Bar with this name already exists");
                return;
            }

            barManager.AddBar(BarName, BarAdress);
            textBoxBarName.Text = "";
            textBoxBarAdress.Text = "";
            PopulateComboBoxBar();
        }

        private void ButtonEditPrice_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPrice.Text, @"(^[1-9]\d*(.\d{1,2})?$)|(^0(\.\d{1,2})?$)"))
            {
                if (comboBoxBar.SelectedItem == null || comboBoxDrink.SelectedItem == null)
                {
                    textBoxPrice.Text = "";
                    MessageBox.Show("Bad input");
                    return;
                }

                int barId = ((Bar)comboBoxBar.SelectedItem).barID;
                int drinkId = ((Drink)comboBoxDrink.SelectedItem).drinkID;
                float newPrice = (float)Convert.ToDouble(textBoxPrice.Text);
                drinkManager.GetDrinkByID(drinkId).EditPrice(barId, newPrice);
                barManager.GetBarByID(barId).EditDrinkPrice(drinkId, newPrice);
            }
            else
            {
                MessageBox.Show("Bad price");
            }

            textBoxPrice.Text = ""; 
        }

        private void PopulateComboBoxBar()
        {
            Dictionary<int, Bar> barDictionary = barManager.barDictionary;
            comboBoxBar.DataSource = new BindingSource(barDictionary.Values, null);
            comboBoxBar.DisplayMember = "barName";
            comboBoxBar.ValueMember = "barID";
            comboBoxBar2.DataSource = new BindingSource(barDictionary.Values, null);
            comboBoxBar2.DisplayMember = "barName";
            comboBoxBar2.ValueMember = "barID";
        }

        private void PopulateComboBoxDrink()
        {
            comboBoxDrink.DisplayMember = "drinkName";
            comboBoxDrink.ValueMember = "drinkID";
        }
    }
}
