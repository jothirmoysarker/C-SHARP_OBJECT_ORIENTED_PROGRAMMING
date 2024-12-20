
namespace Roodside_Assistance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TexUsername = new System.Windows.Forms.TextBox();
            this.TexPassword = new System.Windows.Forms.TextBox();
            this.BsignUp = new System.Windows.Forms.Button();
            this.BsignIn = new System.Windows.Forms.Button();
            this.StartBClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TexUsername
            // 
            this.TexUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexUsername.Location = new System.Drawing.Point(415, 223);
            this.TexUsername.Name = "TexUsername";
            this.TexUsername.Size = new System.Drawing.Size(310, 22);
            this.TexUsername.TabIndex = 3;
            this.TexUsername.Text = "Username";
            this.TexUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TexUsername_MouseClick);
            this.TexUsername.TextChanged += new System.EventHandler(this.TexUsername_TextChanged);
            
            // 
            // TexPassword
            // 
            this.TexPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexPassword.Location = new System.Drawing.Point(415, 300);
            this.TexPassword.Name = "TexPassword";
            this.TexPassword.Size = new System.Drawing.Size(310, 22);
            this.TexPassword.TabIndex = 4;
            this.TexPassword.Text = "Password";
            this.TexPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TexPassword_MouseClick);
            this.TexPassword.TextChanged += new System.EventHandler(this.TexPassword_TextChanged);
            
            // 
            // BsignUp
            // 
            this.BsignUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.BsignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BsignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BsignUp.Location = new System.Drawing.Point(436, 385);
            this.BsignUp.Name = "BsignUp";
            this.BsignUp.Size = new System.Drawing.Size(86, 32);
            this.BsignUp.TabIndex = 5;
            this.BsignUp.Text = "Sign up";
            this.BsignUp.UseVisualStyleBackColor = false;
            this.BsignUp.Click += new System.EventHandler(this.BsignUp_Click);
            // 
            // BsignIn
            // 
            this.BsignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BsignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BsignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BsignIn.Location = new System.Drawing.Point(622, 385);
            this.BsignIn.Name = "BsignIn";
            this.BsignIn.Size = new System.Drawing.Size(86, 32);
            this.BsignIn.TabIndex = 6;
            this.BsignIn.Text = "Sign in";
            this.BsignIn.UseVisualStyleBackColor = false;
            this.BsignIn.Click += new System.EventHandler(this.button2_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StartBClose);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 31);
            this.panel1.TabIndex = 10;
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
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(374, 292);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(802, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BsignIn);
            this.Controls.Add(this.BsignUp);
            this.Controls.Add(this.TexPassword);
            this.Controls.Add(this.TexUsername);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TexUsername;
        private System.Windows.Forms.TextBox TexPassword;
        private System.Windows.Forms.Button BsignUp;
        private System.Windows.Forms.Button BsignIn;
        private System.Windows.Forms.Button StartBClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

