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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from Tow_truck";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_Driver.DataSource = ds.Tables[0];
        }
        int bid;

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView_Driver.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView_Driver.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView_employee.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from Tow_truck where Tid=" + bid + "";
            SqlDataAdapter dak = new SqlDataAdapter(cmd);
            DataSet dss = new DataSet();
            dak.Fill(dss);

            textBox_TorderN.Text = dss.Tables[0].Rows[0][0].ToString();
            textBox_TUpdate.Text = dss.Tables[0].Rows[0][5].ToString();
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
            if (MessageBox.Show("Are You Sure You Want to Exit Truck Driver page", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                SelectOption SO = new SelectOption();
                SO.ShowDialog();

            }
        }

        private void button_TCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button_TSearch_Click(object sender, EventArgs e)
        {
            if (textBox_TSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "select * from Tow_truck where Tid LIKE '" + textBox_TSearch.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_Driver.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "select * from Tow_truck";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_Driver.DataSource = ds.Tables[0];
            }
        }

        private void button_TUpdate_Click(object sender, EventArgs e)
        {
            string Oupdate = textBox_TUpdate.Text;
            string Onumber = textBox_TorderN.Text;
            if (Oupdate != "" && Onumber != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "UPDATE Tow_truck SET Tupdatedorder = 'processing' WHERE Tupdatedorder IS NULL";
                cmd.CommandText = "UPDATE Tow_truck SET Tupdatedorder = '" + Oupdate + "' WHERE Tid = " + Onumber + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Data Updated successfully!");
            }
            else
            {
                MessageBox.Show("Empty Filed not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
