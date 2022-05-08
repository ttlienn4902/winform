namespace b13
{
    partial class frmCheckListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbSach = new System.Windows.Forms.CheckedListBox();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbSach
            // 
            this.clbSach.FormattingEnabled = true;
            this.clbSach.Location = new System.Drawing.Point(45, 35);
            this.clbSach.Name = "clbSach";
            this.clbSach.Size = new System.Drawing.Size(689, 276);
            this.clbSach.TabIndex = 0;
            this.clbSach.SelectedIndexChanged += new System.EventHandler(this.clbSach_SelectedIndexChanged);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(366, 371);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(75, 23);
            this.btnKetqua.TabIndex = 1;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click_1);
            // 
            // frmCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.clbSach);
            this.Name = "frmCheckListBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCheckListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSach;
        private System.Windows.Forms.Button btnKetqua;
    }
}

