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
        public DrinkForm(Drink drink)
        {
            InitializeComponent();
            populateForm(drink);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //TEST AREA #testarea

        public void populateForm(Drink drink)                                                    // Drink class not recognized in form, need help
        {                                                                                      // (i think the binaries have to be tweaked)
            setDrinkName(drink.drinkName);
            populateBarList(drink.drinkLocations);
        }
        public void setDrinkName(string drinkName)
        {
            labelDrinkName.Text = drinkName;
        }
        private void populateBarList(Dictionary<int, float> drinkLocations)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (KeyValuePair<int, float> barEntries in drinkLocations)
            {
                ListViewItem listViewBar = new ListViewItem(barEntries.Key.ToString());
                listViewBar.SubItems.Add(barEntries.Value.ToString());
                listViewBars.Items.Add(listViewBar);
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
