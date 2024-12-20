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
    public partial class Banani : Form
    {
        public Banani()
        {
            InitializeComponent();
        }

        private void button_BSearch_Click(object sender, EventArgs e)
        {
            string msearch = comboBox_Bsearch.Text;
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

        private void label_Nova_Click(object sender, EventArgs e)
        {
            Bnova bn = new Bnova();
            bn.ShowDialog();
        }

        private void label_republic_Click(object sender, EventArgs e)
        {
            Brepublic br = new Brepublic();
            br.ShowDialog();
        }

        private void label_IQBAL_Click(object sender, EventArgs e)
        {
            Biqbal bi = new Biqbal();
            bi.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_NASPRO_Click(object sender, EventArgs e)
        {
            Bnaspro bn = new Bnaspro();
            bn.ShowDialog();
        }
    }
}
