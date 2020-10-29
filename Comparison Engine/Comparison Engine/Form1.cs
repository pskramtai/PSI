using Comparison_Engine.Base_Classes;
using Comparison_Engine.Child_Forms;
using Comparison_Engine.Form_Classes;
using Comparison_Engine.Forms;
using Comparison_Engine.GoogleMap;
using GMap.NET.WindowsForms;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparison_Engine
{
    public partial class Form1 : Form
    {

        public bool barsIsTop = true;
        public DrinkManager drinkManager = DrinkManager.Instance;
        public BarManager barManager = BarManager.Instance;
        public Form activeForm = null;
        public MapForm mainMapForm = null;
        public GMapControl map;
        public MapController mapController = MapController.Instance;
        //Testines funkcijas galima rast ieskant #testarea
        //Tuscias funkcijas(nieko jose nebus daroma) galima rast ieskant #emptyarea
        public Form1()
        {

            InitializeComponent();
            ListButtonMethods.StateCheck(this);
            InitializeProfileClick();
            // probably will need some method here to get current address of the current user
            ChildFormMethods.OpenChildFormMap(this);
            Application.ApplicationExit += new EventHandler(OnApplicationExit); //Method called on app exit
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void ButtonBottom_Click(object sender, EventArgs e)
        {
            barsIsTop = !barsIsTop;
            ListButtonMethods.StateCheck(this);
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchMethods.SearchFunction(FetchSearchKeyword());
        }

        private string FetchSearchKeyword()
        {
            return textBoxSearch.Text;
        }

        //PROFILE MANAGING
        private void InitializeProfileClick()
        {
            panelProfile.Click += (sender, e) => { ChildFormMethods.OpenChildFormProfile(this); };           //This will probably recieve the user info
            labelProfileName.Click += (sender, e) => { ChildFormMethods.OpenChildFormProfile(this); };           //This will probably recieve the user info
            pictureBoxProfile.Click += (sender, e) => { ChildFormMethods.OpenChildFormProfile(this); };           //This will probably recieve the user info
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // OpenChildFormUserContribution(drinks[2], bars[2]);
        }

        //Saves drink and bar data to JSON file
        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (drinkManager.drinkDictionary.Any() && drinkManager.drinkDictionary != null)
            {
                Data.SaveDrinks(drinkManager.drinkDictionary);
            }

            if (barManager.barDictionary.Any() && barManager.barDictionary != null)
            {
                Data.SaveBars(barManager.barDictionary);
            }
        }

        //EMPTY AREA #emptyarea
        private void PanelProfile_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
