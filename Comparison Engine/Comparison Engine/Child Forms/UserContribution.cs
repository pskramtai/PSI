using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comparison_Engine.Child_Forms

{
    public partial class UserContribution : Form
    {
        public UserContribution(Drink drink, Bar bar)
        {
            InitializeComponent();
        }

        
        private void buttonAddDrink_Click(object sender, System.EventArgs e)
        {
        }
        private void buttonAddBar_Click(object sender, System.EventArgs e)
        {
            string BarName = textBoxBarName.Text;
            string BarAdress = textBoxBarAdress.Text;
            //AddBar(BarName, BarAdress);

        }
        private void buttonEditPrice_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
