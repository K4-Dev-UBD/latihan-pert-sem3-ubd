using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pert7
{
    public partial class KalkulatorSederhana : Form
    {
        public KalkulatorSederhana()
        {
            InitializeComponent();
        }

        private enum JenisOperasi { tambah, kurang, bagi, kali };

        private double Hitung(JenisOperasi op)
        {
            double a = double.Parse(txtBilangan1.Text);
            double b = double.Parse(txtBilangan2.Text);
            double c = 0;
            switch (op)
            {
                case JenisOperasi.tambah: c = a + b; break;
                case JenisOperasi.kurang: c = a - b; break;
                case JenisOperasi.kali: c = a * b; break;
                case JenisOperasi.bagi: c = a / b; break;
            }
            return c;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtHasil.Text = Hitung(JenisOperasi.tambah).ToString();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            txtHasil.Text = Hitung(JenisOperasi.kurang).ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            txtHasil.Text = Hitung(JenisOperasi.kali).ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            txtHasil.Text = Hitung(JenisOperasi.bagi).ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void bersih()
        {
            txtBilangan1.Text = "";
            txtBilangan2.Text = "";
            txtHasil.Text = "";
        }
    }
}
