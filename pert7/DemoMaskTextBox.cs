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
    public partial class DemoMaskTextBox : Form
    {
        public DemoMaskTextBox()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            msNIM.Mask = "00000000000";
            msNama.Mask = "???????????????????????";
            msTglLahir.Mask = "00/00/0000";
            msJenisKelamin.Mask = "&";
            msNoTelp.Mask = "00000000000";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string s = null;
            s += "NIM\t\t : " + msNIM.Text;
            s += "\nNama\t\t : " + msNama.Text;
            s += "\nTgl Lahir\t\t : " + msTglLahir.Text;
            s += "\nJenis Kelamin\t : " + msJenisKelamin.Text;
            s += "\nNo.Telp\t\t : " + msNoTelp.Text;
            MessageBox.Show(s, "Information");
        }

    }
}
