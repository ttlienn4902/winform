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
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }

        private void Country_Load(object sender, EventArgs e)
        {

        }
        public string Name = string.Empty;
        public string Capital = string.Empty;
        public override ToString()
        {
            return Name + "-" Capital;
        }
    }
}
