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
    public partial class Track_Torder : Form
    {
        public Track_Torder()
        {
            InitializeComponent();
        }

        private void pictureBox_car2_Click(object sender, EventArgs e)
        {

        }

        private void BCancel2_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "UPDATE Tow_truck SET TupdatedOrder = 'processing' WHERE TupdatedOrder IS NULL";
            cmd.CommandText = "UPDATE Tow_truck SET TupdatedOrder = 'Canceled' WHERE Tid = (SELECT MAX(Tid) FROM Tow_truck) ";
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

        private void Track_Torder_Load(object sender, EventArgs e)
        {
            pictureBox3_Success2.Visible = false;


            timer2.Start();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox_car2.Left = pictureBox_car2.Left + 3;
        }

        private void pictureBox_car2_LocationChanged(object sender, EventArgs e)
        {
            Track_Torder Tr2 = new Track_Torder();
            if (pictureBox_car2.Left >= Tr2.Width)
            {
                pictureBox3_Success2.Visible = true;
                timer2.Stop();
            }
        }
    }
}
