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
  public partial class PinjamBuku : Form {
    public PinjamBuku() {
      InitializeComponent();
    }

    private void btnCari_Click(object sender, EventArgs e) {
      if (txtIdBuku.Text == "") {
        MessageBox.Show("Silahkan Masukkan Id Buku");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("SELECT Judul FROM [Buku] WHERE Id = @Id");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIdBuku.Text);

        con.Open();
        using (SqlDataReader reader = cmd.ExecuteReader()) {
          while (reader.Read()) {
            lblJudulBuku.Text = reader["Judul"].ToString();
          }
        }
        cmd.ExecuteNonQuery();
        con.Close();
      }
    }

    private void btnCariPeminjam_Click(object sender, EventArgs e) {
      if (txtIdPeminjam.Text == "") {
        MessageBox.Show("Silahkan Masukkan Id Buku");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("SELECT Nama FROM [Peminjam] WHERE Id = @Id");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIdPeminjam.Text);

        con.Open();
        using (SqlDataReader reader = cmd.ExecuteReader()) {
          while (reader.Read()) {
            lblNama.Text = reader["Nama"].ToString();
          }
        }
        cmd.ExecuteNonQuery();
        con.Close();
      }
    }

    private void btnSimpan_Click(object sender, EventArgs e) {
      if (txtIdPeminjam.Text == "" || txtIdTransaksi.Text == "" || txtIdBuku.Text == "") {
        MessageBox.Show("Silahkan Masukkan data");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("INSERT INTO [PinjamBuku] VALUES (@Id_Transaksi, @Id_Buku, @Id_Peminjam)");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id_Transaksi", txtIdTransaksi.Text);
        cmd.Parameters.AddWithValue("@Id_Buku", txtIdBuku.Text);
        cmd.Parameters.AddWithValue("@Id_Peminjam", txtIdPeminjam.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show("Berhasil meminjam buku");
        bersih();
      }
    }

    private void btnBatal_Click(object sender, EventArgs e) {
      bersih();
    }

    private void btnTutup_Click(object sender, EventArgs e) {
      Close();
    }

    void bersih() {
      txtIdTransaksi.Text = "";
      txtIdBuku.Text = "";
      txtIdPeminjam.Text = "";
    }
  }
}
