using Comparison_Engine.Base_Classes;
using Comparison_Engine.Forms;
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
        private List<Drink> drinks = new List<Drink>();
        private List<Bar> bars = new List<Bar>();

        //Testines funkcijas galima rast ieskant #testarea
        //Tuscias funkcijas(nieko jose nebus daroma) galima rast ieskant #emptyarea

        //#childforms #search #listbuttons #lists #profile
        public Form1()
        {

            InitializeComponent();
            initializeList();
            openChildFormMap(new MapForm());
            Application.ApplicationExit += new EventHandler(this.onApplicationExit); //Method called on app exit
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //LIST FEATURES      #lists

        private void initializeList()
        {

            populateLists();
            loadBars();
            stateCheck();
        }

        private void populateLists()
        {
            this.bars = Data.GetBars();
            this.drinks = Data.GetDrinks();
        }

        private void stateCheck()
        {
            if (barsIsTop)
            {
                loadBars();                 
                buttonBarsIsTop();

            }
            else
            {
                loadDrinks();                 
                buttonDrinksIsTop();

            }
        }

        private void buttonBottom_Click(object sender, EventArgs e)
        {
            barsIsTop = !barsIsTop;
            stateCheck();
        }
        private void buttonBarsIsTop()
        {
            buttonTop.Text = "Bars";
            buttonBottom.Text = "Drinks";
        }
        private void buttonDrinksIsTop()
        {
            buttonTop.Text = "Drinks";
            buttonBottom.Text = "Bars";
        }

        //loadBars and loadDrinks loads from List

        private void loadBars()
        {
            clearButtonList();
            foreach (Bar bar in bars)
            {
                createBarButton(bar);
            }
        }

        private void loadDrinks()
        {
            clearButtonList();
            foreach (Drink drink in drinks)
            {
                createDrinkButton(drink);
            }
        }

        //SEARCH FEATURES       #search

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchFunction(fetchSearchKeyword());
        }

        private string fetchSearchKeyword()
        {
            return textBoxSearch.Text;
        }

        //Dont worry about it for now
        private void searchFunction(String keyword)
        {

        }

        //OPENING CHILD FORMS    #childforms

        public Form activeForm = null;
        public MapForm mainMapForm = null;
        private void openChildFormMap(Form childForm)                           //this method will probably recieve some sort of mapData in the future
        {
            MapForm mapForm = new MapForm();
            mainMapForm = mapForm;
            configureChildForm(mapForm);
        }
        private void openChildFormBar(Bar bar)
        {
            BarForm barForm = new BarForm(bar);        
            configureChildForm(barForm);
        }
        private void openChildFormDrink(Drink drink)
        {
            DrinkForm drinkForm = new DrinkForm(drink);            
            configureChildForm(drinkForm);
        }
        private void configureChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() != mainMapForm.GetType())
            {
                closeActiveForm();
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
        public void closeActiveForm()
        {
            activeForm.Close();
        }

        //LIST BUTTON CREATOR #listbuttons

        //BAR BUTTON FUNCTIONS
        private void createBarButton(Bar bar)
        {
            Button button = new Button();
            configureBarButton(button, bar);
            bindBar(button, bar);
        }

        private void bindBar(Button button, Bar bar)
        {
            button.Click += (sender, EventArgs) => { barButtonClick(bar); };
        }

        private void barButtonClick(Bar bar)
        {
            openChildFormBar(bar);
        }
        private void configureBarButton(Button button, Bar bar)
        {
            panelSubList.Controls.Add(button);
            button.Text = (bar.barName);
            button.Dock = DockStyle.Top;
        }
        //DRINK BUTTON FUNCTIONS
        private void createDrinkButton(Drink drink)
        {
            Button button = new Button();
            configureDrinkButton(button, drink);
            bindDrink(button, drink);
        }

        private void bindDrink(Button button, Drink drink)
        {
            button.Click += (sender, EventArgs) => { drinkButtonClick(drink); };
        }

        private void drinkButtonClick(Drink drink)
        {
           openChildFormDrink(drink);
        }
        private void configureDrinkButton(Button button, Drink drink)
        {
            panelSubList.Controls.Add(button);
            button.Text = (drink.drinkName);
            button.Dock = DockStyle.Top;
        }

        private void clearButtonList()
        {
            panelSubList.Controls.Clear();
        }

        //PROFILE MANAGING #profile
        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("works");
        }

        //EMPTY AREA #emptyarea



        //TEST AREA #testarea


        //COMMENTED FUNCTIONS #commentedarea



        //Saves drink and bar data to JSON file
        private void onApplicationExit(object sender, EventArgs e)
        {
            if (this.drinks.Any() && this.drinks != null)
            {
                Data.SaveDrinks(this.drinks);
            }

            if (this.bars.Any() && this.bars != null)
            {
                Data.SaveBars(this.bars);
            }
        }
    }
}
