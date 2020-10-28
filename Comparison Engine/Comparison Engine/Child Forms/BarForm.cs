using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Comparison_Engine.Forms
{
    public partial class BarForm : Form
    {
        public Bar bar = null;
        public DrinkManager drinkManager = null;
        public BarForm(Bar tempBar, DrinkManager drinkMan)
        {
            InitializeComponent();
            SaveValues(tempBar, drinkMan);
            PopulateBarForm(bar);
        }
        private void SaveValues(Bar tempBar, DrinkManager drinkMan)
        {
            bar = tempBar;
            drinkManager = drinkMan;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TEST AREA #testarea
        private void PopulateBarForm(Bar bar)
        {
            SetLabelBarName(bar.barName);
            SetLabelBarLocation(bar.barLocation);
            PopulateDrinkList(bar.availableDrinks);
        }
        private void SetLabelBarName(string name)
        {
            labelBarName.Text = name;
        }
        private void SetLabelBarLocation(string location)
        {
            labelBarLocation.Text = location;
        }
        private void PopulateDrinkList(Dictionary<int, float> availableDrinks)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (KeyValuePair<int, float> drinkEntries in availableDrinks)
            {
                ListViewItem listViewDrink = new ListViewItem((drinkManager.GetDrinkByID(drinkEntries.Key).drinkName));
                listViewDrink.SubItems.Add(drinkEntries.Value.ToString());
                listViewDrinks.Items.Add(listViewDrink);
            }

            Cursor.Current = Cursors.Default;
        }

        //EMPTY AREA #emptyarea


    }
}
