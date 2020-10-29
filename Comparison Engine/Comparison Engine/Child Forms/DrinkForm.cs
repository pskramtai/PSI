using Comparison_Engine.Base_Classes;
using Comparison_Engine.GoogleMap;
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
        public BarManager barManager = BarManager.Instance;
        public MapForm mapForm = null;
        public MapController mapController = MapController.Instance;
        public DrinkForm(Drink tempDrink, MapForm mainMapForm)
        {
            InitializeComponent();
            SaveValues(tempDrink, mainMapForm);
            PopulateForm();
        }

        private void SaveValues(Drink tempDrink, MapForm mainMapForm)
        {
            drink = tempDrink;
            mapForm = mainMapForm;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            mapForm.HideTopPanel();
            mapController.RemoveOverlays(mapForm.GetMap());
            Close();
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

        public Image DrinkImage()
        {
            return pictureBoxDrinkIcon.Image;
        }

        private void ButtonShowOnMap_Click(object sender, EventArgs e)
        {
            mapForm.BringToFront();
            mapForm.PopulateDrinkPanel(this);
        }
    }
}
