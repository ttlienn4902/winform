namespace b10
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTahoma = new System.Windows.Forms.RadioButton();
            this.radioVnVogue = new System.Windows.Forms.RadioButton();
            this.radioVnUniverse = new System.Windows.Forms.RadioButton();
            this.radioVnTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.checkBoxStrikeout = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonTím = new System.Windows.Forms.RadioButton();
            this.radioButtonVàng = new System.Windows.Forms.RadioButton();
            this.radioButtonXanh = new System.Windows.Forms.RadioButton();
            this.radioButtonĐỏ = new System.Windows.Forms.RadioButton();
            this.buttonLàmlại = new System.Windows.Forms.Button();
            this.buttonThoát = new System.Windows.Forms.Button();
            this.khungxuat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTahoma);
            this.groupBox1.Controls.Add(this.radioVnVogue);
            this.groupBox1.Controls.Add(this.radioVnUniverse);
            this.groupBox1.Controls.Add(this.radioVnTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu Font";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioTahoma
            // 
            this.radioTahoma.AutoSize = true;
            this.radioTahoma.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTahoma.Location = new System.Drawing.Point(18, 191);
            this.radioTahoma.Name = "radioTahoma";
            this.radioTahoma.Size = new System.Drawing.Size(91, 25);
            this.radioTahoma.TabIndex = 3;
            this.radioTahoma.TabStop = true;
            this.radioTahoma.Text = "Tahoma";
            this.radioTahoma.UseVisualStyleBackColor = true;
            this.radioTahoma.CheckedChanged += new System.EventHandler(this.radioTahoma_CheckedChanged);
            // 
            // radioVnVogue
            // 
            this.radioVnVogue.AutoSize = true;
            this.radioVnVogue.Font = new System.Drawing.Font(".VnVogue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVnVogue.Location = new System.Drawing.Point(18, 143);
            this.radioVnVogue.Name = "radioVnVogue";
            this.radioVnVogue.Size = new System.Drawing.Size(109, 25);
            this.radioVnVogue.TabIndex = 2;
            this.radioVnVogue.TabStop = true;
            this.radioVnVogue.Text = "VnVogue";
            this.radioVnVogue.UseVisualStyleBackColor = true;
            this.radioVnVogue.CheckedChanged += new System.EventHandler(this.radioVnVogue_CheckedChanged);
            // 
            // radioVnUniverse
            // 
            this.radioVnUniverse.AutoSize = true;
            this.radioVnUniverse.Font = new System.Drawing.Font(".VnUniverse", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVnUniverse.Location = new System.Drawing.Point(18, 94);
            this.radioVnUniverse.Name = "radioVnUniverse";
            this.radioVnUniverse.Size = new System.Drawing.Size(99, 24);
            this.radioVnUniverse.TabIndex = 1;
            this.radioVnUniverse.TabStop = true;
            this.radioVnUniverse.Text = "VnUniverse";
            this.radioVnUniverse.UseVisualStyleBackColor = true;
            this.radioVnUniverse.CheckedChanged += new System.EventHandler(this.radioVnUniverse_CheckedChanged);
            // 
            // radioVnTime
            // 
            this.radioVnTime.Font = new System.Drawing.Font(".VnTime", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVnTime.Location = new System.Drawing.Point(18, 45);
            this.radioVnTime.Name = "radioVnTime";
            this.radioVnTime.Size = new System.Drawing.Size(125, 30);
            this.radioVnTime.TabIndex = 0;
            this.radioVnTime.TabStop = true;
            this.radioVnTime.Text = "VnTime";
            this.radioVnTime.UseVisualStyleBackColor = true;
            this.radioVnTime.CheckedChanged += new System.EventHandler(this.rdoVnTime_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxUnderline);
            this.groupBox2.Controls.Add(this.checkBoxStrikeout);
            this.groupBox2.Controls.Add(this.checkBoxItalic);
            this.groupBox2.Controls.Add(this.checkBoxBold);
            this.groupBox2.Location = new System.Drawing.Point(313, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng";
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnderline.Location = new System.Drawing.Point(53, 192);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(100, 20);
            this.checkBoxUnderline.TabIndex = 3;
            this.checkBoxUnderline.Text = " Underline";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            this.checkBoxUnderline.CheckedChanged += new System.EventHandler(this.checkBoxUnderline_CheckedChanged);
            // 
            // checkBoxStrikeout
            // 
            this.checkBoxStrikeout.AutoSize = true;
            this.checkBoxStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStrikeout.Location = new System.Drawing.Point(53, 144);
            this.checkBoxStrikeout.Name = "checkBoxStrikeout";
            this.checkBoxStrikeout.Size = new System.Drawing.Size(90, 20);
            this.checkBoxStrikeout.TabIndex = 2;
            this.checkBoxStrikeout.Text = "Strikeout";
            this.checkBoxStrikeout.UseVisualStyleBackColor = true;
            this.checkBoxStrikeout.CheckedChanged += new System.EventHandler(this.checkBoxStrikeout_CheckedChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Font = new System.Drawing.Font(".VnTime", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItalic.Location = new System.Drawing.Point(53, 95);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(58, 19);
            this.checkBoxItalic.TabIndex = 1;
            this.checkBoxItalic.Text = "Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBold.Location = new System.Drawing.Point(53, 51);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(61, 20);
            this.checkBoxBold.TabIndex = 0;
            this.checkBoxBold.Text = "Bold";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonTím);
            this.groupBox3.Controls.Add(this.radioButtonVàng);
            this.groupBox3.Controls.Add(this.radioButtonXanh);
            this.groupBox3.Controls.Add(this.radioButtonĐỏ);
            this.groupBox3.Location = new System.Drawing.Point(579, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 275);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // radioButtonTím
            // 
            this.radioButtonTím.AutoSize = true;
            this.radioButtonTím.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonTím.Location = new System.Drawing.Point(53, 191);
            this.radioButtonTím.Name = "radioButtonTím";
            this.radioButtonTím.Size = new System.Drawing.Size(51, 20);
            this.radioButtonTím.TabIndex = 4;
            this.radioButtonTím.TabStop = true;
            this.radioButtonTím.Text = "Tím";
            this.radioButtonTím.UseVisualStyleBackColor = true;
            this.radioButtonTím.CheckedChanged += new System.EventHandler(this.radioButtonTím_CheckedChanged);
            // 
            // radioButtonVàng
            // 
            this.radioButtonVàng.AutoSize = true;
            this.radioButtonVàng.ForeColor = System.Drawing.Color.Yellow;
            this.radioButtonVàng.Location = new System.Drawing.Point(49, 143);
            this.radioButtonVàng.Name = "radioButtonVàng";
            this.radioButtonVàng.Size = new System.Drawing.Size(60, 20);
            this.radioButtonVàng.TabIndex = 3;
            this.radioButtonVàng.TabStop = true;
            this.radioButtonVàng.Text = "Vàng";
            this.radioButtonVàng.UseVisualStyleBackColor = true;
            this.radioButtonVàng.CheckedChanged += new System.EventHandler(this.radioButtonVàng_CheckedChanged);
            // 
            // radioButtonXanh
            // 
            this.radioButtonXanh.AutoSize = true;
            this.radioButtonXanh.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonXanh.Location = new System.Drawing.Point(49, 41);
            this.radioButtonXanh.Name = "radioButtonXanh";
            this.radioButtonXanh.Size = new System.Drawing.Size(58, 20);
            this.radioButtonXanh.TabIndex = 2;
            this.radioButtonXanh.TabStop = true;
            this.radioButtonXanh.Text = "Xanh";
            this.radioButtonXanh.UseVisualStyleBackColor = true;
            this.radioButtonXanh.CheckedChanged += new System.EventHandler(this.radioButtonXanh_CheckedChanged);
            // 
            // radioButtonĐỏ
            // 
            this.radioButtonĐỏ.AutoSize = true;
            this.radioButtonĐỏ.ForeColor = System.Drawing.Color.Red;
            this.radioButtonĐỏ.Location = new System.Drawing.Point(49, 94);
            this.radioButtonĐỏ.Name = "radioButtonĐỏ";
            this.radioButtonĐỏ.Size = new System.Drawing.Size(45, 20);
            this.radioButtonĐỏ.TabIndex = 1;
            this.radioButtonĐỏ.TabStop = true;
            this.radioButtonĐỏ.Text = "Đỏ";
            this.radioButtonĐỏ.UseVisualStyleBackColor = true;
            this.radioButtonĐỏ.CheckedChanged += new System.EventHandler(this.radioButtonĐỏ_CheckedChanged);
            // 
            // buttonLàmlại
            // 
            this.buttonLàmlại.Location = new System.Drawing.Point(260, 415);
            this.buttonLàmlại.Name = "buttonLàmlại";
            this.buttonLàmlại.Size = new System.Drawing.Size(75, 23);
            this.buttonLàmlại.TabIndex = 4;
            this.buttonLàmlại.Text = "Làm lại";
            this.buttonLàmlại.UseVisualStyleBackColor = true;
            this.buttonLàmlại.Click += new System.EventHandler(this.buttonLàmlại_Click);
            // 
            // buttonThoát
            // 
            this.buttonThoát.Location = new System.Drawing.Point(464, 415);
            this.buttonThoát.Name = "buttonThoát";
            this.buttonThoát.Size = new System.Drawing.Size(75, 23);
            this.buttonThoát.TabIndex = 5;
            this.buttonThoát.Text = "Thoát";
            this.buttonThoát.UseVisualStyleBackColor = true;
            this.buttonThoát.Click += new System.EventHandler(this.buttonThoát_Click);
            // 
            // khungxuat
            // 
            this.khungxuat.BackColor = System.Drawing.Color.White;
            this.khungxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khungxuat.ForeColor = System.Drawing.Color.Black;
            this.khungxuat.Location = new System.Drawing.Point(52, 40);
            this.khungxuat.Name = "khungxuat";
            this.khungxuat.Size = new System.Drawing.Size(621, 33);
            this.khungxuat.TabIndex = 6;
            this.khungxuat.Text = "Microsoft Visual Studio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.khungxuat);
            this.Controls.Add(this.buttonThoát);
            this.Controls.Add(this.buttonLàmlại);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Program of font";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTahoma;
        private System.Windows.Forms.RadioButton radioVnVogue;
        private System.Windows.Forms.RadioButton radioVnUniverse;
        private System.Windows.Forms.RadioButton radioVnTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonTím;
        private System.Windows.Forms.RadioButton radioButtonVàng;
        private System.Windows.Forms.RadioButton radioButtonXanh;
        private System.Windows.Forms.RadioButton radioButtonĐỏ;
        private System.Windows.Forms.Button buttonLàmlại;
        private System.Windows.Forms.Button buttonThoát;
        private System.Windows.Forms.CheckBox checkBoxUnderline;
        private System.Windows.Forms.CheckBox checkBoxStrikeout;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.Label khungxuat;
    }
}

