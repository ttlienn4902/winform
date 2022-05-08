using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Country;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Country = "France";
            MessageBox.Show("Hãy chọn thành phố cho " + Country);
            EmptyOption(e);
        }
        private void EmptyOption(EventArgs e)
        {
            radBuenosAires.Checked = false;
            radBrazil.Checked = false;
            radTokyo.Checked = false;
            radRome.Checked = false;
            radWashington.Checked = false;
            radMadrid.Checked = false;
            radLondon.Checked = false;
            radAnkara.Checked = false;
            radBudapest.Checked = false;
            radParis.Checked = false;
        }

    }
}
