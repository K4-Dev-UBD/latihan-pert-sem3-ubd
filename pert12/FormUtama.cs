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
  public partial class FormUtama : Form {
    public FormUtama() {
      InitializeComponent();
    }

    private void btnTambah_Click(object sender, EventArgs e) {
      DaftarBuku db = new DaftarBuku();
      db.Show();
    }

    private void btnPeminjam_Click(object sender, EventArgs e) {
      DaftarPeminjam dp = new DaftarPeminjam();
      dp.Show();
    }

    private void btnPinjam_Click(object sender, EventArgs e) {
      PinjamBuku pb = new PinjamBuku();
      pb.Show();
    }
  }
}
