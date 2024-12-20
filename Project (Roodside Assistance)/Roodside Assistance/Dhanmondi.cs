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
    public partial class Dhanmondi : Form
    {
        public Dhanmondi()
        {
            InitializeComponent();
        }

        private void button_DSearch_Click(object sender, EventArgs e)
        {
            string msearch = comboBox_Dsearch.Text;
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

        private void label_navana_Click(object sender, EventArgs e)
        {
            Dnavana dn = new Dnavana();
            dn.ShowDialog();
        }

        private void label_rokey_Click(object sender, EventArgs e)
        {
            Drocky dr = new Drocky();
            dr.ShowDialog();
        }

        private void label_carcare_Click(object sender, EventArgs e)
        {
            Dcarcare dc = new Dcarcare();
            dc.ShowDialog();
        }

        private void label_nur_Click(object sender, EventArgs e)
        {
            Dnur dn = new Dnur();
            dn.ShowDialog();

        }

        private void label_anandas_Click(object sender, EventArgs e)
        {
            Danandas da = new Danandas();
            da.ShowDialog();

        }
    }
}
