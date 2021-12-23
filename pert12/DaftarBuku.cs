using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pert12 {
  public partial class DaftarBuku : Form {
    public DaftarBuku() {
      InitializeComponent();
      bukuDataGridView.Refresh();
    }

    private void btnTambah_Click(object sender, EventArgs e) {
      TambahBuku tb = new TambahBuku(this);
      tb.Show();
    }

    private void btnTutup_Click(object sender, EventArgs e) {
      Close();
    }

    private void btnHapus_Click(object sender, EventArgs e) {
      HapusBuku hb = new HapusBuku();
      hb.Show();
      Close();
    }

    private void DaftarBuku_Load(object sender, EventArgs e) {
      // TODO: This line of code loads data into the 'buku_ubdDataSet.Buku' table. You can move, or remove it, as needed.
      this.bukuTableAdapter.Fill(this.buku_ubdDataSet.Buku);

    }

    public void refreshDataGridView() {
      SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

      SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Buku", con);
      DataSet ds = new DataSet();
      sda.Fill(ds, "Buku");

      bukuDataGridView.DataSource = ds.Tables[0];
    }
  }
}
