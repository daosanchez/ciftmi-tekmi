using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace form19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtYaz.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Bu bir çift sayıdır.");
            }
            if (sayi % 2 == 1)
            {
                MessageBox.Show("Bu bir tek sayıdır.");
            }
        }
    }
}
