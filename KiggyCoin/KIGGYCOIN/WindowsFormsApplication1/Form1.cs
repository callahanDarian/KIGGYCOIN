using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int KiggyCoin;
        int PowerClick;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KiggyCoin = KiggyCoin + 1 + PowerClick;
            lblCoins.Text = Convert.ToString(KiggyCoin);
        }

        private void btnACP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            PowerClick++;
        }
    }
}
