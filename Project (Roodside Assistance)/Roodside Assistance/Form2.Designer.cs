
namespace Roodside_Assistance
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_Rusername = new System.Windows.Forms.TextBox();
            this.textBox_REmail = new System.Windows.Forms.TextBox();
            this.textBox_Rpassword = new System.Windows.Forms.TextBox();
            this.textBox_RCpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BcreateAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.singinc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 452);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_Rusername
            // 
            this.textBox_Rusername.Location = new System.Drawing.Point(402, 155);
            this.textBox_Rusername.Name = "textBox_Rusername";
            this.textBox_Rusername.Size = new System.Drawing.Size(329, 20);
            this.textBox_Rusername.TabIndex = 2;
            this.textBox_Rusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_REmail
            // 
            this.textBox_REmail.Location = new System.Drawing.Point(402, 212);
            this.textBox_REmail.Name = "textBox_REmail";
            this.textBox_REmail.Size = new System.Drawing.Size(329, 20);
            this.textBox_REmail.TabIndex = 3;
            // 
            // textBox_Rpassword
            // 
            this.textBox_Rpassword.Location = new System.Drawing.Point(402, 272);
            this.textBox_Rpassword.Name = "textBox_Rpassword";
            this.textBox_Rpassword.Size = new System.Drawing.Size(329, 20);
            this.textBox_Rpassword.TabIndex = 4;
            this.textBox_Rpassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_RCpassword
            // 
            this.textBox_RCpassword.Location = new System.Drawing.Point(402, 331);
            this.textBox_RCpassword.Name = "textBox_RCpassword";
            this.textBox_RCpassword.Size = new System.Drawing.Size(329, 20);
            this.textBox_RCpassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Conform Password";
            // 
            // BcreateAccount
            // 
            this.BcreateAccount.BackColor = System.Drawing.SystemColors.Highlight;
            this.BcreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BcreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcreateAccount.ForeColor = System.Drawing.Color.Black;
            this.BcreateAccount.Location = new System.Drawing.Point(480, 398);
            this.BcreateAccount.Name = "BcreateAccount";
            this.BcreateAccount.Size = new System.Drawing.Size(174, 23);
            this.BcreateAccount.TabIndex = 10;
            this.BcreateAccount.Text = "Create Account";
            this.BcreateAccount.UseVisualStyleBackColor = false;
            this.BcreateAccount.Click += new System.EventHandler(this.BcreateAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.singinc);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 31);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Roadside Assistance";
            // 
            // singinc
            // 
            this.singinc.BackColor = System.Drawing.SystemColors.Highlight;
            this.singinc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singinc.Location = new System.Drawing.Point(760, 3);
            this.singinc.Name = "singinc";
            this.singinc.Size = new System.Drawing.Size(39, 25);
            this.singinc.TabIndex = 7;
            this.singinc.Text = "X";
            this.singinc.UseVisualStyleBackColor = false;
            this.singinc.Click += new System.EventHandler(this.StartBClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BcreateAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_RCpassword);
            this.Controls.Add(this.textBox_Rpassword);
            this.Controls.Add(this.textBox_REmail);
            this.Controls.Add(this.textBox_Rusername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_Rusername;
        private System.Windows.Forms.TextBox textBox_REmail;
        private System.Windows.Forms.TextBox textBox_Rpassword;
        private System.Windows.Forms.TextBox textBox_RCpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BcreateAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button singinc;
    }
}