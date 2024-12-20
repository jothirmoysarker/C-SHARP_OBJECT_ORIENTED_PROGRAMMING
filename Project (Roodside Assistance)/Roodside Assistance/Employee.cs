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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from Oilorder1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_employee.DataSource = ds.Tables[0];

        }
        int bid;
        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView_employee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView_employee.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView_employee.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from Oilorder1 where bid=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            textBox_orderN.Text = ds.Tables[0].Rows[0][0].ToString();
            textBox_Update.Text = ds.Tables[0].Rows[0][6].ToString();

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
            if (MessageBox.Show("Are You Sure You Want to Exit Employee page", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                SelectOption SO = new SelectOption();
                SO.ShowDialog();

            }
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if(textBox_Search.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "select * from Oilorder1 where bid LIKE '"+textBox_Search.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_employee.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "select * from Oilorder1";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_employee.DataSource = ds.Tables[0];

            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string Oupdate = textBox_Update.Text;
            string Onumber = textBox_orderN.Text;
            if (Oupdate != "" && Onumber != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "UPDATE Oilorder1 SET bupdatedorder = 'processing' WHERE bupdatedorder IS NULL";
                cmd.CommandText = "UPDATE Oilorder1 SET bupdatedorder = '"+Oupdate+"' WHERE bid = "+Onumber+"";
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
