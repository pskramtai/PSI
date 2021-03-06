﻿using Comparison_Engine.Base_Classes;
using Comparison_Engine.GoogleMap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Comparison_Engine.Forms
{
    public partial class BarForm : Form
    {
        public Bar bar = null;
        public DrinkManager drinkManager = DrinkManager.Instance;
        public MapForm mapForm = null;
        public MapController mapController = MapController.Instance;

        public BarForm(Bar tempBar, MapForm mainMapForm)
        {
            InitializeComponent();
            SaveValues(tempBar, mainMapForm);
            PopulateBarForm();
        }

        private void SaveValues(Bar tempBar, MapForm mainMapForm)
        {
            bar = tempBar;
            mapForm = mainMapForm;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            mapForm.HideTopPanel();
            mapController.RemoveOverlays(mapForm.GetMap());
            Close();
        }

        private void PopulateBarForm()
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

        public Image BarImage()
        {
            return pictureBoxBarIcon.Image;
        }

        private void ButtonShowOnMap_Click(object sender, EventArgs e)
        {
            mapForm.BringToFront();
            mapForm.PopulateBarPanel(this);
        }

        //EMPTY AREA #emptyarea
    }
}
