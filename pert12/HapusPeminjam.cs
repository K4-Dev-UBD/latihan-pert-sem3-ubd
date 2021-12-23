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
  public partial class HapusPeminjam : Form {
    public HapusPeminjam() {
      InitializeComponent();
    }

    private void btnCari_Click(object sender, EventArgs e) {
      if (txtIdPeminjam.Text == "") {
        MessageBox.Show("Silahkan Masukkan Id Peminjam");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("SELECT Nama FROM [Peminjam] WHERE Id = @Id");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIdPeminjam.Text);

        con.Open();
        using (SqlDataReader reader = cmd.ExecuteReader()) {
          while (reader.Read()) {
            txtNama.Text = reader["Nama"].ToString();
          }
        }
        cmd.ExecuteNonQuery();
        con.Close();
      }
    }

    private void btnHapus_Click(object sender, EventArgs e) {
      if (txtIdPeminjam.Text == "") {
        MessageBox.Show("Silahkan Masukkan Id Peminjam");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("DELETE FROM [Peminjam] WHERE Id = @Id");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIdPeminjam.Text);

        con.Open();
        cmd.ExecuteNonQuery();

        MessageBox.Show("Data berhasil di hapus");
        con.Close();

        bersih();
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

    void bersih() {
      txtIdPeminjam.Text = "";
      txtNama.Text = "";
    }
  }
}
