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
  public partial class HapusBuku : Form {
    public HapusBuku() {
      InitializeComponent();
    }

    private void btnHapus_Click(object sender, EventArgs e) {
      if (txtIdBuku.Text == "") {
        MessageBox.Show("Silahkan Masukkan Id Buku");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("DELETE FROM [Buku] WHERE Id = @Id");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIdBuku.Text);

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

    private void btnCari_Click(object sender, EventArgs e) {
      if(txtIdBuku.Text == "") {
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
            txtJudul.Text = reader["Judul"].ToString();
          }
        }
        cmd.ExecuteNonQuery();
        con.Close();
      }
    }

    private void btnTutup_Click(object sender, EventArgs e) {
      DaftarBuku db = new DaftarBuku();
      db.Show();
      Close();
    }

    void bersih() {
      txtIdBuku.Text = "";
      txtJudul.Text = "";
    }
  }
}
