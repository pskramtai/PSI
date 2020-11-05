using Comparison_Engine.GoogleMap;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comparison_Engine.Forms
{
    public partial class MapForm : Form
    {
        private MapController mapControl = MapController.Instance;
        private BarForm barForm = null;
        private DrinkForm drinkForm = null;

        public MapForm()
        {
            InitializeComponent();
            HideTopPanel();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            mapControl.InitMap(map);
        }

        public GMapControl GetMap()
        {
            return map;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (barForm == null)
            {
                ButtonBackDrink_Click();
            }
            else
            {
                ButtonBackBar_Click();
            }
        }

        private void ButtonBackBar_Click()
        {
            HideTopPanel();
            barForm.BringToFront();
            barForm = null;
        }

        private void ButtonBackDrink_Click()
        {
            HideTopPanel();
            drinkForm.BringToFront();
            drinkForm = null;
        }

        public void HideTopPanel()
        {
            panelTop.Visible = false;
        }

        public void PopulateBarPanel(BarForm mainBarForm)
        {
            panelTop.Visible = true;
            barForm = mainBarForm;
            pictureBoxItem.Image = barForm.BarImage();
            labelItemName.Text = barForm.bar.barName;
        }

        public void PopulateDrinkPanel(DrinkForm mainDrinkForm)
        {
            panelTop.Visible = true;
            drinkForm = mainDrinkForm;
            pictureBoxItem.Image = drinkForm.DrinkImage();
            labelItemName.Text = drinkForm.drink.drinkName;
        }

        //EMPTY METHODS
        private void LabelItemName_Click(object sender, EventArgs e)
        {

        }
    }
}
