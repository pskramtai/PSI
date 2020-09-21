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
        public Form1()
        {

            InitializeComponent();

            treeView1.Nodes.Add("Bars");
            treeView1.Nodes.Add("Drinks");

            treeView1.Nodes[0].Nodes.Add("Minusai");
            treeView1.Nodes[0].Nodes.Add("Būsi Antras");
            treeView1.Nodes[0].Nodes.Add("Pilies 9");

            treeView1.Nodes[1].Nodes.Add("Nonalcoholic Beer");
            treeView1.Nodes[1].Nodes.Add("Nonalcoholic Wine");
            treeView1.Nodes[1].Nodes.Add("Nonalcoholic Vodka");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
