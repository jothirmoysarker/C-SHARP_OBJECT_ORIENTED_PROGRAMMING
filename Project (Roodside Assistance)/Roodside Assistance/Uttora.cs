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
    public partial class Uttora : Form
    {
        public Uttora()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string msearch = comboBox_Usearch.Text;
            // Uttora Khilkhet Bonani Mirpur Dhanmondi
            if (msearch!="")
            {
                if(msearch== "Khilkhet")
                {
                    this.Hide();
                    Khilkhet Kh = new Khilkhet();
                    Kh.ShowDialog();
                }
                else if (msearch== "Bonani")
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

        private void label_AG_Click(object sender, EventArgs e)
        {
            U_AG ag = new U_AG();
            ag.ShowDialog();
        }

        private void label_Nabil_Click(object sender, EventArgs e)
        {
            Umukter mu = new Umukter();
            mu.ShowDialog();
        }

        private void label_sAto_Click(object sender, EventArgs e)
        {
            USato us = new USato();
            us.ShowDialog();
        }

        private void label_newAto_Click(object sender, EventArgs e)
        {
            Unewato un = new Unewato();
            un.ShowDialog();
        }

        private void label_Muktar_Click(object sender, EventArgs e)
        {
            Uspeedauto Spee = new Uspeedauto();
            Spee.ShowDialog();
        }
    }
}
