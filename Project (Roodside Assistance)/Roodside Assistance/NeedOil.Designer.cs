
namespace Roodside_Assistance
{
    partial class NeedOil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeedOil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.needoilClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_brand = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_amount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_deliveryOption = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Batton_placeOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.needoilClose);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 31);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Roadside Assistance";
            // 
            // needoilClose
            // 
            this.needoilClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.needoilClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.needoilClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needoilClose.Location = new System.Drawing.Point(760, 3);
            this.needoilClose.Name = "needoilClose";
            this.needoilClose.Size = new System.Drawing.Size(39, 25);
            this.needoilClose.TabIndex = 7;
            this.needoilClose.Text = "X";
            this.needoilClose.UseVisualStyleBackColor = false;
            this.needoilClose.Click += new System.EventHandler(this.StartBClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.FormattingEnabled = true;
            this.comboBox_brand.Items.AddRange(new object[] {
            "Castrol",
            "Motul",
            "Quaker State",
            "E.I.F",
            "Havoline",
            "Valvoline",
            "Pennzoil",
            "Liqui Moly"});
            this.comboBox_brand.Location = new System.Drawing.Point(458, 86);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.Size = new System.Drawing.Size(215, 21);
            this.comboBox_brand.TabIndex = 16;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Diesel fuel",
            "Petroleum"});
            this.comboBox_type.Location = new System.Drawing.Point(458, 145);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(215, 21);
            this.comboBox_type.TabIndex = 16;
            // 
            // comboBox_amount
            // 
            this.comboBox_amount.FormattingEnabled = true;
            this.comboBox_amount.Items.AddRange(new object[] {
            "500 ml",
            "1 L",
            "1500 ml",
            "2 L",
            "2500 ml",
            "3 L",
            "3500 ml",
            "4 L",
            "4500 ml",
            "5 L"});
            this.comboBox_amount.Location = new System.Drawing.Point(458, 204);
            this.comboBox_amount.Name = "comboBox_amount";
            this.comboBox_amount.Size = new System.Drawing.Size(215, 21);
            this.comboBox_amount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select The Brand Of Oil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "What type Of Oil you want";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "The Amount Of Oil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox_deliveryOption
            // 
            this.comboBox_deliveryOption.FormattingEnabled = true;
            this.comboBox_deliveryOption.Items.AddRange(new object[] {
            "Normal  60 tk",
            "Emergency 100 tk"});
            this.comboBox_deliveryOption.Location = new System.Drawing.Point(458, 264);
            this.comboBox_deliveryOption.Name = "comboBox_deliveryOption";
            this.comboBox_deliveryOption.Size = new System.Drawing.Size(215, 21);
            this.comboBox_deliveryOption.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Delivery Option";
            // 
            // Batton_placeOrder
            // 
            this.Batton_placeOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.Batton_placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Batton_placeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batton_placeOrder.ForeColor = System.Drawing.Color.Black;
            this.Batton_placeOrder.Location = new System.Drawing.Point(473, 391);
            this.Batton_placeOrder.Name = "Batton_placeOrder";
            this.Batton_placeOrder.Size = new System.Drawing.Size(174, 23);
            this.Batton_placeOrder.TabIndex = 20;
            this.Batton_placeOrder.Text = "Place Order";
            this.Batton_placeOrder.UseVisualStyleBackColor = false;
            this.Batton_placeOrder.Click += new System.EventHandler(this.BcreateAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Type your location";
            // 
            // comboBox_location
            // 
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Items.AddRange(new object[] {
            "Khilkhet, Dhaka1229",
            "Nikunjo"});
            this.comboBox_location.Location = new System.Drawing.Point(458, 323);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(215, 21);
            this.comboBox_location.TabIndex = 22;
            // 
            // NeedOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.comboBox_location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Batton_placeOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_deliveryOption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_amount);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox_brand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NeedOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedOil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button needoilClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox_brand;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_deliveryOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Batton_placeOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_location;
    }
}