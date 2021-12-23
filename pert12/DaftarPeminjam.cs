using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pert12 {
  public partial class DaftarPeminjam : Form {
    public DaftarPeminjam() {
      InitializeComponent();
      dataGridView1.Refresh();
    }

    private void btnTambah_Click(object sender, EventArgs e) {
      TambahPeminjam tp = new TambahPeminjam();
      tp.Show();
      Close();
    }

    private void btnTutup_Click(object sender, EventArgs e) {
      Close();
    }

    private void btnHapus_Click(object sender, EventArgs e) {
      HapusPeminjam hp = new HapusPeminjam();
      hp.Show();
      Close();
    }

    private void DaftarPeminjam_Load(object sender, EventArgs e) {
      // TODO: This line of code loads data into the 'buku_ubdDataSet1.Peminjam' table. You can move, or remove it, as needed.
      this.peminjamTableAdapter.Fill(this.buku_ubdDataSet1.Peminjam);

    }
  }
}
