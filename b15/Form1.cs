using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b15
{
    public partial class frmMaunen : Form
    {
        public frmMaunen()
        {
            InitializeComponent();
        }

        private void frmMaunen_Load(object sender, EventArgs e)
        {

        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hsbRed_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(hsbRed.Value,hsbGreen.Value,hsbBlue.Value);
            lblRed_.Text = hsbRed.Value.ToString();
        }
       
      

        private void hsbGreen_ValueChanged_1(object sender, EventArgs e)
        {
    this.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblGreen_.Text = hsbGreen.Value.ToString();
        }

        private void hsbBlue_ValueChanged_1(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblBlue_.Text = hsbBlue.Value.ToString();
        }
    }
}
