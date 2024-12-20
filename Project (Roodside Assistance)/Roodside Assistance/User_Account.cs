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
    public partial class Admin_Account : Form
    {
        public Admin_Account()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit Admin page", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                SelectOption SO = new SelectOption();
                SO.ShowDialog();

            }
            
        }

        private void User_Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_UserA.DataSource = ds.Tables[0];

        }
    }
}
