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
    public partial class NeedTowTruck : Form
    {
        private string connectionString = @"Data Source=DESKTOP-7OBFT94\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
        public NeedTowTruck()
        {
            InitializeComponent();
        }

        private void needoilClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 F1 = new Form1();
                F1.ShowDialog();

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOption SO = new SelectOption();
            SO.ShowDialog();
        }

        private void BcreateAccount_Click(object sender, EventArgs e)
        {
            string Vlocation = comboBox_TL.Text;
            string Vtype = comboBox_VType.Text;
            string Vnumber = comboBox_Number.Text;
            string Vemail = comboBox_Email.Text;

            if (Vlocation != "" && Vtype != "" && Vnumber != "" && Vemail != "")
            {
                if(Vemail.Contains("@gmail.com") && !Vemail.Any(char.IsUpper))
                {
                    if(Vnumber.Length == 11 && Vnumber.StartsWith("01"))
                    {

                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();

                                string sql = "INSERT INTO Tow_truck ([Tlocation], [Ttype], [Tnumber], [Temail]) " + "VALUES (@Location, @Type, @Number, @Email)";

                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Location", Vlocation);
                                    cmd.Parameters.AddWithValue("@Type", Vtype);
                                    cmd.Parameters.AddWithValue("@Number", Vnumber);
                                    cmd.Parameters.AddWithValue("@Email", Vemail);


                                    cmd.ExecuteNonQuery();
                                }
                            }

                            if (MessageBox.Show("Order Placed successfully! Do you want to track your Order", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                this.Hide();
                                Track_Torder Tr2 = new Track_Torder();
                                Tr2.ShowDialog();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error inserting data: " + ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Phone Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        }

        private void NeedTowTruck_Load(object sender, EventArgs e)
        {

        }
    }
}
