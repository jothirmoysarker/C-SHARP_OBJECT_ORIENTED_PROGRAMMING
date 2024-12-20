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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = TexPassword.Text;
            string usenname = TexUsername.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-7OBFT94\\SQLEXPRESS;Initial Catalog=Roadside_Assistance1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from Registration where Username='"+TexUsername.Text+ "' and Upassword='"+TexPassword.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SelectOption SE = new SelectOption();
            Employee EM = new Employee();
            Driver DI = new Driver();
            Admin_Account AD = new Admin_Account();

            if (password !="" && usenname !="")
            {
                if (password == "user" && usenname == "user")
                {
                    this.Hide();
                    SE.ShowDialog();

                }
                else if (password == "employee" && usenname == "employee")
                {
                    this.Hide();
                    EM.ShowDialog();

                }
                else if (password == "Driver" && usenname == "Driver")
                {
                    this.Hide();
                    DI.ShowDialog();

                }
                else if (password == "Admin" && usenname == "Admin")
                {
                    this.Hide();
                    AD.ShowDialog();

                }
                else if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    SE.ShowDialog();

                }
                else
                {
                    MessageBox.Show("WRONG USERNAME AND PASSWORD!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            else
            {
                MessageBox.Show("Enter your Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        


        private void TexPassword_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void StartBClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want to Exit","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }

        private void BsignUp_Click(object sender, EventArgs e)
        {
            this.Hide();  //hide form1
            SelectOption so = new SelectOption();
            Form2 f2 = new Form2();
            f2.ShowDialog();  // its going to freeze click event
            /*f2 = null;
            so= null;
            this.Show();*/
        }

        private void TexUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TexUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (TexUsername.Text == "Username")
            {
                TexUsername.Clear();

            }
        }

        private void TexPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TexPassword.Text == "Password")
            {
                TexPassword.Clear();
                TexPassword.PasswordChar = '*';
            }
        }
    }
}
