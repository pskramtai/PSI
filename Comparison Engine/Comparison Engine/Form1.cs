using Comparison_Engine.Base_Classes;
using Comparison_Engine.Child_Forms;
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

        private bool barsIsTop = true;
        private DrinkManager drinkManager = DrinkManager.Instance;
        private BarManager barManager = BarManager.Instance;
        public Form activeForm = null;
        public MapForm mainMapForm = null;
        private GMapControl map;
        private MapController mapController = MapController.Instance;
        //Testines funkcijas galima rast ieskant #testarea
        //Tuscias funkcijas(nieko jose nebus daroma) galima rast ieskant #emptyarea

        //#childforms #search #listbuttons #lists #profile
        public Form1()
        {

            InitializeComponent();
            StateCheck();
            InitializeProfileClick();
            // probably will need some method here to get current address of the current user
            OpenChildFormMap();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit); //Method called on app exit
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //LIST FEATURES      #lists

        private void StateCheck()
        {
            if (barsIsTop)
            {
                LoadBars(barManager.barDictionary);                 
                ButtonBarsIsTop();

            }
            else
            {
                LoadDrinks(drinkManager.drinkDictionary);                 
                ButtonDrinksIsTop();

            }
        }

        private void ButtonBottom_Click(object sender, EventArgs e)
        {
            barsIsTop = !barsIsTop;
            StateCheck();
        }
        private void ButtonBarsIsTop()
        {
            buttonTop.Text = "Bars";
            buttonBottom.Text = "Drinks";
        }
        private void ButtonDrinksIsTop()
        {
            buttonTop.Text = "Drinks";
            buttonBottom.Text = "Bars";
        }

        //LoadBars and LoadDrinks loads from List

        private void LoadBars(Dictionary <int, Bar> barsDictionary)
        {
            ClearButtonList();
            foreach (Bar bar in barsDictionary.Values)
            {
                CreateBarButton(bar);
            }
        }

        private void LoadDrinks(Dictionary <int, Drink> drinksDictionary)
        {
            ClearButtonList();
            foreach (Drink drink in drinksDictionary.Values)
            {
                CreateDrinkButton(drink);
            }
        }

        //SEARCH FEATURES       #search

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchFunction(FetchSearchKeyword());
        }

        private string FetchSearchKeyword()
        {
            return textBoxSearch.Text;
        }

        //Dont worry about it for now(maybe start worrying about this a little bit)
        private void SearchFunction(String keyword)
        {

        }

        //OPENING CHILD FORMS    #childforms

        private void OpenChildFormMap()
        {
            MapForm mapForm = new MapForm();
            mainMapForm = mapForm;
            ConfigureChildForm(mapForm);
            map = mapForm.GetMap();
        }
        private void OpenChildFormBar(Bar bar)
        {
            BarForm barForm = new BarForm(bar, drinkManager, mainMapForm, mapController);        
            ConfigureChildForm(barForm);           
        }
        private void OpenChildFormDrink(Drink drink)
        {
            DrinkForm drinkForm = new DrinkForm(drink, barManager, mainMapForm, mapController);            
            ConfigureChildForm(drinkForm);
        }
        private void OpenChildFormProfile()                 //This will probably recieve the user info
        {
            ProfileForm profileForm = new ProfileForm();         //This will probably recieve the user info
            ConfigureChildForm(profileForm);
        }

        private void OpenChildFormUserContribution(Drink drink, Bar bar)
        {
            Child_Forms.UserContribution userContribution = new UserContribution(drink, bar);
            //CloseActiveForm();            //#commentedarea
            ConfigureChildForm(userContribution);
        }
    private void ConfigureChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() != mainMapForm.GetType())
            {
                CloseActiveForm();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void CloseActiveForm()
        {
            activeForm.Close();
        }

        //LIST BUTTON CREATOR #listbuttons

        //BAR BUTTON FUNCTIONS
        private void CreateBarButton(Bar bar)
        {
            Button button = new Button();
            ConfigureBarButton(button, bar);
            BindBar(button, bar);
        }

        private void BindBar(Button button, Bar bar)
        {
            button.Click += (sender, EventArgs) => { BarButtonClick(bar); };
        }

        private void BarButtonClick(Bar bar)
        {
            OpenChildFormBar(bar);
            mapController.RemoveOverlays(map);
            mapController.ShowRoute(map, bar.barLocation);
        }
        private void ConfigureBarButton(Button button, Bar bar)
        {
            panelSubList.Controls.Add(button);
            button.Text = (bar.barName);
            button.Dock = DockStyle.Top;
        }
        //DRINK BUTTON FUNCTIONS
        private void CreateDrinkButton(Drink drink)
        {
            Button button = new Button();
            ConfigureDrinkButton(button, drink);
            BindDrink(button, drink);
        }

        private void BindDrink(Button button, Drink drink)
        {
            button.Click += (sender, EventArgs) => { DrinkButtonClick(drink); };
        }

        private void DrinkButtonClick(Drink drink)
        {
           OpenChildFormDrink(drink);
           mapController.RemoveOverlays(map);
           mapController.ShowBarsWithDrink(map, drink, barManager.barDictionary);
        }
        private void ConfigureDrinkButton(Button button, Drink drink)
        {
            panelSubList.Controls.Add(button);
            button.Text = (drink.drinkName);
            button.Dock = DockStyle.Top;
        }

        private void ClearButtonList()
        {
            panelSubList.Controls.Clear();
        }

        //PROFILE MANAGING #profile
        private void InitializeProfileClick()
        {
            panelProfile.Click += (sender, e) => { OpenChildFormProfile(); };           //This will probably recieve the user info
            labelProfileName.Click += (sender, e) => { OpenChildFormProfile(); };           //This will probably recieve the user info
            pictureBoxProfile.Click += (sender, e) => { OpenChildFormProfile(); };           //This will probably recieve the user info
        }

        //EMPTY AREA #emptyarea
        private void PanelProfile_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
           // OpenChildFormUserContribution(drinks[2], bars[2]);
        }


        //TEST AREA #testarea


        //COMMENTED FUNCTIONS #commentedarea


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
    }
}
