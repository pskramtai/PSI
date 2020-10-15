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
        public BarForm(Bar bar)
        {
            InitializeComponent();
            populateBarForm(bar);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TEST AREA #testarea
        private void populateBarForm(Bar bar)
        {
            setLabelBarName(bar.barName);
            setLabelBarLocation(bar.location);
            populateDrinkList(bar.availableDrinks);
        }
        private void setLabelBarName(string name)
        {
            labelBarName.Text = name;
        }
        private void setLabelBarLocation(string location)
        {
            labelBarLocation.Text = location;
        }
        private void populateDrinkList(Dictionary<Drink, float> availableDrinks)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (KeyValuePair<Drink, float> drinkEntries in availableDrinks)
            {
                ListViewItem listViewDrink = new ListViewItem(drinkEntries.Key.drinkName);
                listViewDrink.SubItems.Add(drinkEntries.Value.ToString());
                listViewDrinks.Items.Add(listViewDrink);
            }

            Cursor.Current = Cursors.Default;
        }

        //EMPTY AREA #emptyarea


    }
}
