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
    public partial class NeedOil : Form
    {
        private string connectionString = @"Data Source=DESKTOP-7OBFT94\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
        public NeedOil()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOption SO = new SelectOption();
            SO.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BcreateAccount_Click(object sender, EventArgs e)
        {
            string brand = comboBox_brand.Text;
            string type = comboBox_type.Text;
            string amount = comboBox_amount.Text;
            string delivery = comboBox_deliveryOption.Text;
            string location = comboBox_location.Text;

            if (brand != "" && type != "" && amount != "" && delivery != "" && location != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string sql = "INSERT INTO Oilorder1 ([bBrand], [bType], [bAmount], [bDelivery], [bLocation]) " + "VALUES (@Brand, @Type, @Amount, @Delivery, @Location)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Brand", brand);
                            cmd.Parameters.AddWithValue("@Type", type);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@Delivery", delivery);
                            cmd.Parameters.AddWithValue("@Location", location);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    
                    if (MessageBox.Show("Order Placed successfully! Do you want to track your Order", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Hide();
                        Track_Order Tr = new Track_Order();
                        Tr.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Filed not Allowed","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

    }



    

    
    
}
