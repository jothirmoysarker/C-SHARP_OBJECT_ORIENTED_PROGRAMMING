
namespace Roodside_Assistance
{
    partial class Track_Order
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Track_Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.needoilClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3_Success = new System.Windows.Forms.PictureBox();
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_Success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.needoilClose);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 31);
            this.panel1.TabIndex = 13;
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
            this.needoilClose.Click += new System.EventHandler(this.needoilClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox3_Success);
            this.panel2.Controls.Add(this.BCancel);
            this.panel2.Controls.Add(this.pictureBox_car);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 455);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox3_Success
            // 
            this.pictureBox3_Success.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_Success.Image")));
            this.pictureBox3_Success.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3_Success.Name = "pictureBox3_Success";
            this.pictureBox3_Success.Size = new System.Drawing.Size(802, 452);
            this.pictureBox3_Success.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3_Success.TabIndex = 2;
            this.pictureBox3_Success.TabStop = false;
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_car.Image")));
            this.pictureBox_car.Location = new System.Drawing.Point(3, 139);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(100, 60);
            this.pictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_car.TabIndex = 1;
            this.pictureBox_car.TabStop = false;
            this.pictureBox_car.LocationChanged += new System.EventHandler(this.pictureBox_car_LocationChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Location = new System.Drawing.Point(256, 283);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(258, 23);
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Cancel Order";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // Track_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Track_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track_Order";
            this.Load += new System.EventHandler(this.Track_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_Success)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button needoilClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_car;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3_Success;
        private System.Windows.Forms.Button BCancel;
    }
}