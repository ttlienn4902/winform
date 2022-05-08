using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace b13
{
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

        private void clbSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void frmCheckListBox_Load(object sender, EventArgs e)
        {
            clbSach.Items.Add("Visual Basic.NET 2005");
            clbSach.Items.Add("Visual C#.NET 2005");
            clbSach.Items.Add("Lập trình Oracle");
            clbSach.Items.Add("Lập trình Cơ sở dữ liệu");
            clbSach.Items.Add("Lập trình C");
            clbSach.Items.Add("Lập trình Pascal");
            clbSach.Items.Add("Phân tích thiết kế hướng đối tượng");
            clbSach.Items.Add("Lập trình C For Win");
            clbSach.Items.Add("Nhập môn Xử lý ảnh");
            clbSach.Items.Add("Đồ họa máy tính");
            clbSach.MultiColumn = true;
            clbSach.ColumnWidth = clbSach.Width / 2;
        } 
        private void clbSach_ItemCheck(object sender, ItemCheckEventArgs e)

        {
            if (e.NewValue == CheckState.Checked)
                MessageBox.Show("Bạn đã chọn sách" + clbSach.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
        }
       

        private void btnKetqua_Click_1(object sender, EventArgs e)
        {
            string str = "";
            foreach(string item in clbSach.CheckedItems)
                str=str+item+", ";
            str.Remove(str.Length-2,2);
            MessageBox.Show("Bạn đã chọn sách" +str,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
