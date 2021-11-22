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
  public partial class Menu : Form {
    public Menu() {
      InitializeComponent();
    }

    private void kalkulatorSederhanaToolStripMenuItem_Click(object sender, EventArgs e) {
      KalkulatorSederhana ks = new KalkulatorSederhana();
      ks.Show();
    }

    private void maskTextBoxToolStripMenuItem_Click(object sender, EventArgs e) {
      MaskTextBox ms = new MaskTextBox();
      ms.Show();
    }

    private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e) {
      CheckBox cb = new CheckBox();
      cb.Show();
    }

    private void listBoxToolStripMenuItem_Click(object sender, EventArgs e) {
      ListBox lb = new ListBox();
      lb.Show();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
      Environment.Exit(0);
    }
  }
}
