using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b17
{
    public partial class frmMove : Form
    {
        bool kt;

        public frmMove()
        {
            InitializeComponent();
        }

        private void frmMove_Load(object sender, EventArgs e)
        {
            kt=true; 
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if(kt)
            {
                if(lblMove.Left+lblMove.Width<this.Width)
                    lblMove.Left=lblMove.Left+13; else kt=false;
            }    
           //vx hơi chờm ra ngoài
            if (!kt)
            {
                if (lblMove.Left > 0)
                    lblMove.Left = lblMove.Left - 13; else kt = true;
            }
           
        }
    }
}
