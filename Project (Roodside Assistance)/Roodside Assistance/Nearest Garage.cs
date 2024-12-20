using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;


namespace Roodside_Assistance
{
    public partial class Nearest_Garage : Form
    {
        string bingkey = "";

        public Nearest_Garage()
        {
            InitializeComponent();
            bingkey = "AoIvgCCOsmemXd9NJ_1P1jS28ChFYirQl3VBmjTN02wwl6F6rgVgY0U9pI1jyuEA";
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOption SO = new SelectOption();
            SO.Show();
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Salim_Auto_car_solution a1 = new Salim_Auto_car_solution();
            a1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = textBox1_street.Text;
            string city = textBox2_city.Text;
            string state = textBox3_state.Text;
            

            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");
                //queryAddress.Append("https://www.google.com/maps/@23.823331,90.4223771,15z?entry=ttu");

                if (textBox1_street.Text != String.Empty)
                {
                    queryAddress.Append(street + "," + "+");
                }
                if (textBox2_city.Text != String.Empty)
                {
                    queryAddress.Append(street + "," + "+");
                }
                if (textBox3_state.Text != String.Empty)
                {
                    queryAddress.Append(street + "," + "+");
                }
                
                queryAddress.Append("&key=" + bingkey);
                webBrowser1.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to retrieve data");
            }

        }

        private void textBox2_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Track_Order Tr = new Track_Order();
            Tr.ShowDialog();
        }
    }
}
