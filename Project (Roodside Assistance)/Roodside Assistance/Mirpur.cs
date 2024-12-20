using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roodside_Assistance
{
    public partial class Mirpur : Form
    {
        public Mirpur()
        {
            InitializeComponent();
        }

        private void button_MSearch_Click(object sender, EventArgs e)
        {
            string msearch = comboBox_Msearch.Text;
            // Uttora Khilkhet Bonani Mirpur Dhanmondi
            if (msearch != "")
            {
                if (msearch == "Khilkhet")
                {
                    this.Hide();
                    Khilkhet Kh = new Khilkhet();
                    Kh.ShowDialog();
                }
                else if (msearch == "Bonani")
                {
                    this.Hide();
                    Banani Ba = new Banani();
                    Ba.ShowDialog();
                }
                else if (msearch == "Mirpur")
                {
                    this.Hide();
                    Mirpur Mi = new Mirpur();
                    Mi.ShowDialog();
                }
                else if (msearch == "Dhanmondi")
                {
                    this.Hide();
                    Dhanmondi Dh = new Dhanmondi();
                    Dh.ShowDialog();
                }
                else if (msearch == "Uttora")
                {
                    this.Hide();
                    Uttora Ut = new Uttora();
                    Ut.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Map is not Ragister Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Empty Filed not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOption SO = new SelectOption();
            SO.ShowDialog();
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

        private void label_adiba_Click(object sender, EventArgs e)
        {
            Madiba ma = new Madiba();
            ma.ShowDialog();

        }

        private void label_bismillah_Click(object sender, EventArgs e)
        {
            Mbismillah mb = new Mbismillah();
            mb.ShowDialog();
        }

        private void label_vai_Click(object sender, EventArgs e)
        {
            Mvai mv = new Mvai();
            mv.ShowDialog();
        }

        private void label_juwel_Click(object sender, EventArgs e)
        {
            Mjuwel mj = new Mjuwel();
            mj.ShowDialog();
        }

        private void label_ssauto_Click(object sender, EventArgs e)
        {
            Mssauto mst = new Mssauto();
            mst.ShowDialog();

        }
    }
}
