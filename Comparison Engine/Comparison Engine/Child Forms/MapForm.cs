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

        public MapForm()
        {
            InitializeComponent();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            mapControl.InitMap(map);
        }

        public GMapControl GetMap()
        {
            return map;
        }
    }
}
