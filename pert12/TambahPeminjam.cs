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
  public partial class TambahPeminjam : Form {
    public TambahPeminjam() {
      InitializeComponent();
      txtIdPeminjam.Focus();
    }

    private void btnSimpan_Click(object sender, EventArgs e) {
      if (txtIdPeminjam.Text == "" || txtAlamat.Text == "" || txtNama.Text == "" || txtTelp.Text == "") {
        MessageBox.Show("Data belum lengkap");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("INSERT INTO Peminjam VALUES (@Id, @Nama, @Alamat, @Telp)");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIdPeminjam.Text);
        cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
        cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
        cmd.Parameters.AddWithValue("@Telp", txtTelp.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        MessageBox.Show("Data Berhasil ditambahkan");
        con.Close();

        bersih();
        txtIdPeminjam.Focus();
      }
    }

    private void btnBatal_Click(object sender, EventArgs e) {
      bersih();
    }

    private void btnTutup_Click(object sender, EventArgs e) {
      DaftarPeminjam dp = new DaftarPeminjam();
      dp.Show();
      Close();
    }

    private void bersih() {
      txtIdPeminjam.Text = "";
      txtAlamat.Text = "";
      txtNama.Text = "";
      txtTelp.Text = "";
    }
  }
}
