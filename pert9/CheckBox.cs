using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pert9 {
  public partial class CheckBox : Form {
    public CheckBox() {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e) {
      string hobi = "Hobi";
      if (cNgoding.Checked) hobi += "\n- " + cNgoding.Text;
      if (cBola.Checked) hobi += "\n- " + cBola.Text;
      if (cMusik.Checked) hobi += "\n- " + cMusik.Text;
      if (cBerenang.Checked) hobi += "\n- " + cBerenang.Text;
      if (cLari.Checked) hobi += "\n- " + cLari.Text;
      MessageBox.Show(hobi);
    }
  }
}
