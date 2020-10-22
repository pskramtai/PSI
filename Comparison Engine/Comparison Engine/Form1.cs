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

        private GMapControl map;
        private MapController mapController = MapController.Instance;

        //Testines funkcijas galima rast ieskant #testarea
        //Tuscias funkcijas(nieko jose nebus daroma) galima rast ieskant #emptyarea

        //#childforms #search #listbuttons #lists #profile
        public Form1()
        {

            InitializeComponent();

            //populateLists();                          //#commentedarea
            //loadBars();                               //#commentedarea
            initializeList();
            // probably will need some method here to get current address of the current user
            openChildFormMap();
            Application.ApplicationExit += new EventHandler(this.onApplicationExit); //Method called on app exit
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //LIST FEATURES      #lists

        private void initializeList()
        {
            //#testarea
            initializeTest();
            

            populateLists();
            stateSwitch();
        }

        //Someone needs to make this happen
        private void populateLists()
        {
            this.bars = Data.GetBars();
            this.drinks = Data.GetDrinks();
        }

        private void stateSwitch()
        {
            if (barsIsTop)
            {
                //loadBars();                 //#commentedarea
                buttonBarsIsTop();

                //Test functions #testarea
                loadTestBarButtons();
            }
            else
            {
                //loadDrinks();                 //#commentedarea
                buttonDrinksIsTop();

                //Test functions #testarea
                loadTestDrinkButtons();
            }
        }

        private void buttonBottom_Click(object sender, EventArgs e)
        {
            barsIsTop = !barsIsTop;
            stateSwitch();
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
        private void openChildFormMap()                           //this method will probably recieve some sort of mapData in the future
        {
            MapForm mapForm = new MapForm();
            configureChildForm(mapForm);
            map = mapForm.GetMap();
        }
        private void openChildFormBar(Bar bar)
        {
            BarForm barForm = new BarForm(bar);
            //closeActiveForm();            //#commentedarea
            configureChildForm(barForm);

            mapController.ShowRoute(map, bar.location); // WILL SHOW ROUTE TO SELECTED BAR
            
        }
        /*private void whateverTheFunctionWillBeCalled()
        {
            mapController.RemoveOverlays(map); // THIS SHOULD CLEAN THE MAP
        }*/
        private void openChildFormDrink(Drink drink)
        {
            DrinkForm drinkForm = new DrinkForm(drink);
            //closeActiveForm();            //#commentedarea
            configureChildForm(drinkForm);

            mapController.ShowBarsWithDrink(map, drink, bars); // WILL SHOW BARS WITH SELECTED DRINKS

        }
        private void openChildFormUserContribution(Drink drink, Bar bar)
        {
            Child_Forms.UserContribution userContribution = new UserContribution(drink, bar);
            //closeActiveForm();            //#commentedarea
            configureChildForm(userContribution);
        }
    private void configureChildForm(Form childForm)
        {
            //if (activeForm.GetType != MapForm.get)              //#commentedarea

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void closeActiveForm()
        {
            activeForm.Close();
        }

        //LIST BUTTON CREATOR #listbuttons
        private void createBarButton(Bar bar)
        {
            
        }

        private void createDrinkButton(Drink drink)
        {
            /*                          //#commentedarea
            Button button = new Button();
            createButton(button);
            button.Tag = drink;
            button.Click += drinkButtonClick;
            */
        }

        private void createButton(Button button)
        {

        }

        private void drinkButtonClick(object sender, EventArgs e)
        {
           // openChildFormDrink(new DrinkForm(), (Drink)this.Tag);     //#commentedarea

        }


        private void clearButtonList()
        {
            panelSideMenu.Controls.Clear();
        }

        //PROFILE MANAGING #profile
        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("works");
        }

        //EMPTY AREA #emptyarea


        //TEST AREA #testarea

        private void initializeTest()
        {
            initializeTestBars();
            initializeTestDrinks();
            initializeCrossReference();
        }
        private void initializeTestBars()
        {
            bars.Add(new Bar(1, "Pilies 6", "Pilies g. 6"));
            bars.Add(new Bar(2, "Pliusai", "Gedimino g. 9"));
            bars.Add(new Bar(3, "Būsi Trečias", "Totorių g. 8"));
        }
        private void initializeTestDrinks()
        {
            drinks.Add(new Drink(1, "Beer"));
            drinks.Add(new Drink(2, "Vodka"));
            drinks.Add(new Drink(3, "Cuba Libre"));
        }
        private void initializeCrossReference()
        {
            drinks[0].AddBar(1, 3.5f);
            drinks[0].AddBar(2, 1.9f);
            drinks[0].AddBar(3, 3f);
            drinks[1].AddBar(2, 4f);
            drinks[2].AddBar(2, 4.5f);
            drinks[2].AddBar(3, 5f);

            bars[0].AddDrink(drinks[0].drinkID, 3.5f);
            bars[1].AddDrink(drinks[0].drinkID, 1.9f);
            bars[1].AddDrink(drinks[1].drinkID, 4f);
            bars[1].AddDrink(drinks[2].drinkID, 4.5f);
            bars[2].AddDrink(drinks[0].drinkID, 3f);
            bars[2].AddDrink(drinks[2].drinkID, 5f);
        }
        private void loadTestBarButtons()
        {
            buttonTest1.Text = bars[0].barName;
            buttonTest2.Text = bars[1].barName;
            buttonTest3.Text = bars[2].barName;
        }
        private void loadTestDrinkButtons()
        {
            buttonTest1.Text = drinks[0].drinkName;
            buttonTest2.Text = drinks[1].drinkName;
            buttonTest3.Text = drinks[2].drinkName;
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            if (barsIsTop)
            {
                openChildFormBar(bars[0]);
            }
            else
            {
                openChildFormDrink(drinks[0]);
            }
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            if (barsIsTop)
            {
                openChildFormBar(bars[1]);
            }
            else
            {
                openChildFormDrink(drinks[1]);
            }
        }

        private void buttonTest3_Click(object sender, EventArgs e)
        {
            if (barsIsTop)
            {
                openChildFormBar(bars[2]);
            }
            else
            {
                openChildFormDrink(drinks[2]);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            openChildFormUserContribution(drinks[2], bars[2]);
        }

    //COMMENTED FUNCTIONS #commenterarea

    /*
     //loadBars and loadDrinks loads from List

    private void loadBars()
    {
        foreach(Bar bar in bars)
        {
            createBarButton(bar);
        }
    }

    private void loadDrinks()
    {
        foreach (Drink drink in drinks)
        {
            createDrinkButton(drink);
        }
    }


     */


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
