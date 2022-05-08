namespace b15
{
    partial class frmMaunen
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
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed_ = new System.Windows.Forms.Label();
            this.lblGreen_ = new System.Windows.Forms.Label();
            this.lblBlue_ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(105, 236);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(569, 28);
            this.hsbRed.TabIndex = 0;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            this.hsbRed.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(105, 363);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(569, 33);
            this.hsbBlue.TabIndex = 1;
            this.hsbBlue.ValueChanged += new System.EventHandler(this.hsbBlue_ValueChanged_1);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(105, 294);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(569, 29);
            this.hsbGreen.TabIndex = 2;
            this.hsbGreen.ValueChanged += new System.EventHandler(this.hsbGreen_ValueChanged_1);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(30, 247);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(33, 16);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(30, 307);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(42, 16);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(30, 380);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(34, 16);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "Blue";
            // 
            // lblRed_
            // 
            this.lblRed_.AutoSize = true;
            this.lblRed_.Location = new System.Drawing.Point(725, 247);
            this.lblRed_.Name = "lblRed_";
            this.lblRed_.Size = new System.Drawing.Size(44, 16);
            this.lblRed_.TabIndex = 6;
            this.lblRed_.Text = "label1";
            // 
            // lblGreen_
            // 
            this.lblGreen_.AutoSize = true;
            this.lblGreen_.Location = new System.Drawing.Point(725, 307);
            this.lblGreen_.Name = "lblGreen_";
            this.lblGreen_.Size = new System.Drawing.Size(44, 16);
            this.lblGreen_.TabIndex = 7;
            this.lblGreen_.Text = "label2";
            // 
            // lblBlue_
            // 
            this.lblBlue_.AutoSize = true;
            this.lblBlue_.Location = new System.Drawing.Point(725, 363);
            this.lblBlue_.Name = "lblBlue_";
            this.lblBlue_.Size = new System.Drawing.Size(44, 16);
            this.lblBlue_.TabIndex = 8;
            this.lblBlue_.Text = "label3";
            // 
            // frmMaunen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBlue_);
            this.Controls.Add(this.lblGreen_);
            this.Controls.Add(this.lblRed_);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbRed);
            this.Name = "frmMaunen";
            this.Text = "Mau nen Form";
            this.Load += new System.EventHandler(this.frmMaunen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed_;
        private System.Windows.Forms.Label lblGreen_;
        private System.Windows.Forms.Label lblBlue_;
    }
}

