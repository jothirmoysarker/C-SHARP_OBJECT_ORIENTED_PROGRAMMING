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
    public partial class SelectOption : Form
    {
        public SelectOption()
        {
            InitializeComponent();
        }

        private void BneedOil_Click(object sender, EventArgs e)
        {
            this.Hide();
            NeedOil ads = new NeedOil();
            ads.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uttora Ut = new Uttora();
            Ut.ShowDialog();
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

        private void SelectOption_Load(object sender, EventArgs e)
        {

        }

        private void BneedTowTruck_Click(object sender, EventArgs e)
        {
            this.Hide();
            NeedTowTruck NTT = new NeedTowTruck();
            NTT.ShowDialog();
        }
    }
}
