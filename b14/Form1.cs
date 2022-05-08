using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b14
{
    public partial class frmPTBH : Form
    {
        public frmPTBH()
        {
            InitializeComponent();
        }

        private void frmPTBH_Load(object sender, EventArgs e)
        {
        }
           

            private void PTBH(int a, int b, int c)
            {
                double delta, x1, x2;
                if ((a == 0) || (b == 0) || (c == 0))
                {
                    txtKetqua.Text = "Không giải vì không phải phương trình bậc hai đủ";
                    btnGiaiPTBH.Enabled = false;
                    return;
                }
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    txtKetqua.Text = txtKetqua.Text + "Phương trình vô nghiệm";
                    btnGiaiPTBH.Enabled = false;
                    return;
                }
                if (delta == 0)
                {
                    x1 = Math.Round((-b / (2.0 * a)), 2);
                    txtKetqua.Text = txtKetqua.Text + "Phương trình có nghiệm kép";
                    txtX1.Text = Convert.ToString(x1);
                    txtX2.Text = Convert.ToString(x1);
                    btnGiaiPTBH.Enabled = false;
                    return;
                }
                x1 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                x2 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                txtKetqua.Text = txtKetqua.Text + "Phương trình có 2 nghiệm phân biệt";
                txtX1.Text = Convert.ToString(x1);
                txtX2.Text = Convert.ToString(x2);
                btnGiaiPTBH.Enabled = false;
            }

            private void EmptyText()
            {
                txtX1.Text = "";
                txtX2.Text = "";
            }

            private void nudNhapA_ValueChanged(object sender, EventArgs e)
            {
                txtKetqua.Text = "A=" + nudNhapA.Value + System.Environment.NewLine;
                txtKetqua.Text = txtKetqua.Text + "B=" + nudNhapB.Value +
    System.Environment.NewLine;
                txtKetqua.Text = txtKetqua.Text + "C=" + nudNhapC.Value +
    System.Environment.NewLine;
                btnGiaiPTBH.Enabled = true;
                EmptyText();
            }

        private void btnGiaiPTBH_Click_1(object sender, EventArgs e)
        {
            PTBH(Convert.ToInt32(nudNhapA.Value), Convert.ToInt32(nudNhapB.Value)
                , Convert.ToInt32(nudNhapC.Value));
        }
        private void nudNhapB_ValueChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = "A=" + nudNhapA.Value + System.Environment.NewLine;
            txtKetqua.Text = txtKetqua.Text + "B=" + nudNhapB.Value +
System.Environment.NewLine;
            txtKetqua.Text = txtKetqua.Text + "C=" + nudNhapC.Value +
System.Environment.NewLine;
            btnGiaiPTBH.Enabled = true;
            EmptyText();
        }
        private void nudNhapC_ValueChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = "A=" + nudNhapA.Value + System.Environment.NewLine;
            txtKetqua.Text = txtKetqua.Text + "B=" + nudNhapB.Value +
System.Environment.NewLine;
            txtKetqua.Text = txtKetqua.Text + "C=" + nudNhapC.Value +
System.Environment.NewLine;
            btnGiaiPTBH.Enabled = true;
            EmptyText();
        }


    }
    }

