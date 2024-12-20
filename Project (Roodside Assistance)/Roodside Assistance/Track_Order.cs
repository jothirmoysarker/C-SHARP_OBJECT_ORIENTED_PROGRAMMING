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
    public partial class Track_Order : Form
    {
        public Track_Order()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOption SO = new SelectOption();
            SO.ShowDialog();
        }

        private void Track_Order_Load(object sender, EventArgs e)
        {
            pictureBox3_Success.Visible = false;
          

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_car.Left = pictureBox_car.Left + 3;
        }

        private void pictureBox_car_LocationChanged(object sender, EventArgs e)
        {
            Track_Order Tr = new Track_Order();
            if(pictureBox_car.Left >= Tr.Width )
            {
                pictureBox3_Success.Visible = true;
                timer1.Stop();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "UPDATE Oilorder1 SET bupdatedorder = 'processing' WHERE bupdatedorder IS NULL";
            cmd.CommandText = "UPDATE Oilorder1 SET bupdatedorder = 'Canceled' WHERE bid = (SELECT MAX(bid) FROM Oilorder1) ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Order Cancled", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                SelectOption SO = new SelectOption();
                SO.ShowDialog();

            }
            else
            {
                this.Hide();
                SelectOption SO = new SelectOption();
                SO.ShowDialog();
            }
        }
    }
}
