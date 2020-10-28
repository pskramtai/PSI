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
    public partial class DrinkForm : Form
    {
        public Drink drink = null;
        public BarManager barManager = null;
        public DrinkForm(Drink drnk, BarManager barMan)
        {
            InitializeComponent();
            SaveValues(drnk, barMan);
            PopulateForm();
        }

        private void SaveValues(Drink drnk, BarManager barMan)
        {
            drink = drnk;
            barManager = barMan;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //TEST AREA #testarea

        public void PopulateForm()                                                    
        {                                                                                    
            SetDrinkName(drink.drinkName);
            PopulateBarList(drink.drinkLocations);
        }
        public void SetDrinkName(string drinkName)
        {
            labelDrinkName.Text = drinkName;
        }
        private void PopulateBarList(Dictionary<int, float> drinkLocations)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (KeyValuePair<int, float> barEntries in drinkLocations)
            {
                ListViewItem listViewBar = new ListViewItem((barManager.GetBarByID(barEntries.Key)).barName);
                listViewBar.SubItems.Add(barEntries.Value.ToString());
                listViewBars.Items.Add(listViewBar);
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
