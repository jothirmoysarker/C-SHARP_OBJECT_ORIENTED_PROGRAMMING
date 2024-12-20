
namespace Roodside_Assistance
{
    partial class SelectOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectOption));
            this.BneedOil = new System.Windows.Forms.Button();
            this.BneedTowTruck = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BneedOil
            // 
            this.BneedOil.BackColor = System.Drawing.SystemColors.Highlight;
            this.BneedOil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BneedOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BneedOil.Location = new System.Drawing.Point(440, 123);
            this.BneedOil.Name = "BneedOil";
            this.BneedOil.Size = new System.Drawing.Size(258, 23);
            this.BneedOil.TabIndex = 1;
            this.BneedOil.Text = "Need Oil";
            this.BneedOil.UseVisualStyleBackColor = false;
            this.BneedOil.Click += new System.EventHandler(this.BneedOil_Click);
            // 
            // BneedTowTruck
            // 
            this.BneedTowTruck.BackColor = System.Drawing.SystemColors.Highlight;
            this.BneedTowTruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BneedTowTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BneedTowTruck.Location = new System.Drawing.Point(440, 225);
            this.BneedTowTruck.Name = "BneedTowTruck";
            this.BneedTowTruck.Size = new System.Drawing.Size(258, 23);
            this.BneedTowTruck.TabIndex = 2;
            this.BneedTowTruck.Text = "Need Tow Truck";
            this.BneedTowTruck.UseVisualStyleBackColor = false;
            this.BneedTowTruck.Click += new System.EventHandler(this.BneedTowTruck_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(440, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Nearest Garage";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StartBClose);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 31);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Roadside Assistance";
            // 
            // StartBClose
            // 
            this.StartBClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.StartBClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBClose.Location = new System.Drawing.Point(760, 3);
            this.StartBClose.Name = "StartBClose";
            this.StartBClose.Size = new System.Drawing.Size(39, 25);
            this.StartBClose.TabIndex = 7;
            this.StartBClose.Text = "X";
            this.StartBClose.UseVisualStyleBackColor = false;
            this.StartBClose.Click += new System.EventHandler(this.StartBClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SelectOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BneedTowTruck);
            this.Controls.Add(this.BneedOil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelectOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectOption";
            this.Load += new System.EventHandler(this.SelectOption_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BneedOil;
        private System.Windows.Forms.Button BneedTowTruck;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBClose;
    }
}