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
  public partial class ListBox : Form {
    public ListBox() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      if (txtItem.Text.Length > 0) {
        listKiri.Items.Add(txtItem.Text);
        txtItem.Clear();
        txtItem.Focus();
      } else {
        MessageBox.Show("Elemen baru Tidak Boleh Kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      int indeksAktif = listKiri.SelectedIndex;
      if (indeksAktif >= 0) {
        listKanan.Items.Add((string)listKiri.SelectedItem);
        listKiri.Items.RemoveAt(indeksAktif);
      }
    }

    private void button3_Click(object sender, EventArgs e) {
      foreach(string elemen in listKiri.Items) {
        listKanan.Items.Add(elemen);
      }

      listKiri.Items.Clear();
    }

    private void button4_Click(object sender, EventArgs e) {
      int indeksAktif = listKanan.SelectedIndex;
      if (indeksAktif >= 0) {
        listKiri.Items.Add((string)listKanan.SelectedItem);
        listKanan.Items.RemoveAt(indeksAktif);
      }
    }

    private void button5_Click(object sender, EventArgs e) {
      foreach (string elemen in listKanan.Items) {
        listKiri.Items.Add(elemen);
      }

      listKanan.Items.Clear();
    }
  }
}
