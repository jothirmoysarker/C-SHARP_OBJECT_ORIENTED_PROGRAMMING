using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Roodside_Assistance
{
    public partial class Form2 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-7OBFT94\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BcreateAccount_Click(object sender, EventArgs e)
        {
            string Rusername = textBox_Rusername.Text;
            string Remail = textBox_REmail.Text;
            string Rpass = textBox_Rpassword.Text;
            string RCpass = textBox_RCpassword.Text;

            if (Rusername != "" && Remail != "" && Rpass != "" && RCpass != "")
            {
                if (Remail.Contains("@gmail.com") && !Remail.Any(char.IsUpper))
                {
                    if (Rpass.Length >= 8 && Rpass.Any(char.IsUpper) && (Rpass.Contains("#") || Rpass.Contains("@") || Rpass.Contains("%")))
                    {
                        if (Rpass == RCpass)
                        {
                            try
                            {
                                using (SqlConnection conn = new SqlConnection(connectionString))
                                {
                                    conn.Open();

                                    string sql = "INSERT INTO Registration ([Username], [Uemail], [Upassword], [CUpassword]) " + "VALUES (@Username, @Email, @Pass, @CPass)";

                                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@Username", Rusername);
                                        cmd.Parameters.AddWithValue("@Email", Remail);
                                        cmd.Parameters.AddWithValue("@Pass", Rpass);
                                        cmd.Parameters.AddWithValue("@CPass", RCpass);


                                        cmd.ExecuteNonQuery();
                                    }
                                }


                                if (MessageBox.Show("Account Created successfully!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    this.Hide();
                                    Form1 F1 = new Form1();
                                    F1.ShowDialog();

                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Error inserting data: " + ex.Message);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Password Dose not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must contain 8 or more charecters, one uper case latter and any of '!@#' this Charecters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Filed not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            /*if (Rusername != "" && Remail != "" && Rpass != "" && RCpass != "")
            {
                if (Rpass == RCpass)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            string sql = "INSERT INTO Registration ([Username], [Uemail], [Upassword], [CUpassword]) " + "VALUES (@Username, @Email, @Pass, @CPass)";

                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", Rusername);
                                cmd.Parameters.AddWithValue("@Email", Remail);
                                cmd.Parameters.AddWithValue("@Pass", Rpass);
                                cmd.Parameters.AddWithValue("@CPass", RCpass);


                                cmd.ExecuteNonQuery();
                            }
                        }


                        if (MessageBox.Show("Account Created successfully!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Form1 F1 = new Form1();
                            F1.ShowDialog();

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passsword Dose NOt Mach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Filed not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

        }

        private void StartBClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 F1 = new Form1();
                F1.ShowDialog();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
