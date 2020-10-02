using Comparison_Engine.Base_Classes;
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
        private List<Drink> drinks = new List<Drink>(); //added constructors to fix build errors
        private List<Bar> bars = new List<Bar>();


        public Form1()
        {

            InitializeComponent();
            populateLists();                //Does nothing, for now. Somenone should get on it
            testDriveLists();               //temporary, delete when populateLists() is done
            loadBars();

            openChildFormMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //LIST FEATURES

        private void buttonBottom_Click(object sender, EventArgs e)
        {
            barsIsTop = !barsIsTop;
            stateSwitch();
        }

        private void stateSwitch()
        {
            if (barsIsTop) {
                loadBars();
                buttonBarsIsTop();
            }
            else { 
                loadDrinks();
                buttonDrinksIsTop();
            }
        }

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

        //BUTTON CREATORS
        
        private void createBarButton(Bar bar)
        {

        }

        private void createDrinkButton(Drink drink)
        {

        }

        private void createButton()
        {

        }

        //PROGRAMMING IS SO EASY

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

        //Someone needs to make this happen
        private void populateLists()
        {

        }

        //placeholder, populates lists. Delete when populateLists() is done
        private void testDriveLists()
        {
            for (int i = 0; i < 50; i++)
            {
                String barName;
                barName = "Bar" + i;
                bars.Add(new Bar(i, barName, "location"));
                drinks.Add(new Drink(i, "testName"));                                  //fixed this
            }
        }
        

        //SEARCH FEATURES

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



        //OPENING CHILD FORMS
        private void openChildFormMap()
        {

        }
        private void openChildFormBar(Bar bar)
        {

        }
        private void openChildFormDrink(Drink drink)
        {

        }
        private void closeChildForm()
        {
            openChildFormMap();
        }

    }
}
