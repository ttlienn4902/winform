using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void buttonThoát_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("b có muốn thoát k?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
        private void rdoVnTime_CheckedChanged(object sender, EventArgs e)
        {
            radioVnTime.Font = new Font("VnTime", 10);
        }
        private void buttonLàmlại_Click(object sender, EventArgs e)
        {
                khungxuat.Font = new Font(khungxuat.Font, FontStyle.Regular);
            khungxuat.ForeColor = Color.Black;
            


        }

        private void radioButtonXanh_CheckedChanged(object sender, EventArgs e)
        {
            khungxuat.ForeColor = Color.Blue;
        }

        private void radioButtonĐỏ_CheckedChanged(object sender, EventArgs e)
        {
            khungxuat.ForeColor = Color.Red;
        }

        private void radioButtonVàng_CheckedChanged(object sender, EventArgs e)
        {
            khungxuat.ForeColor = Color.Yellow;
        }

        private void radioButtonTím_CheckedChanged(object sender, EventArgs e)
        {
            khungxuat.ForeColor = Color.Purple;
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxBold.Checked)
                khungxuat.Font = new Font(khungxuat.Font, khungxuat.Font.Style | FontStyle.Bold);
            else
                khungxuat.Font = new Font(khungxuat.Font, khungxuat.Font.Style & ~FontStyle.Bold);
        }
    
        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxItalic.Checked)
                khungxuat.Font = new Font(khungxuat.Font,khungxuat.Font.Style |FontStyle.Italic);
            else 
                khungxuat.Font = new Font(khungxuat.Font,khungxuat.Font.Style&~FontStyle.Italic);
            
        }

        private void checkBoxStrikeout_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxStrikeout.Checked)
                khungxuat.Font = new Font(khungxuat.Font, khungxuat.Font.Style | FontStyle.Strikeout);
            else
                khungxuat.Font = new Font(khungxuat.Font, khungxuat.Font.Style & ~FontStyle.Strikeout);
        }

        private void checkBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnderline.Checked)
                khungxuat.Font = new Font(khungxuat.Font, khungxuat.Font.Style | FontStyle.Underline);
            else
                khungxuat.Font = new Font(khungxuat.Font, khungxuat.Font.Style & ~FontStyle.Underline);

        }
            private void radioVnUniverse_CheckedChanged(object sender, EventArgs e)
        {
            radioVnUniverse.Font = new Font("VnUniverse", 13);
        }

        private void radioVnVogue_CheckedChanged(object sender, EventArgs e)
        {
            radioVnVogue.Font = new Font("VnVogue", 13);
        }

        private void radioTahoma_CheckedChanged(object sender, EventArgs e)
        {
            radioTahoma.Font = new Font("Tahoma", 13);
        }
    }
}
