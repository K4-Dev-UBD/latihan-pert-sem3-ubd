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
  public partial class TambahBuku : Form {
    DaftarBuku mainForm = null;
    public TambahBuku(Form connectForm) {
      InitializeComponent();
      mainForm = connectForm as DaftarBuku;
    }

    private void btnSimpan_Click(object sender, EventArgs e) {
      

      if (txtIDBuku.Text == "" || txtJudul.Text == "" || txtPenulis.Text == "") {
        MessageBox.Show("Data belum lengkap");
      } else {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\buku_ubd.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("INSERT INTO Buku VALUES (@Id, @Judul, @Penulis)");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id", txtIDBuku.Text);
        cmd.Parameters.AddWithValue("@Judul", txtJudul.Text);
        cmd.Parameters.AddWithValue("@Penulis", txtPenulis.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        MessageBox.Show("Data Berhasil ditambahkan");
        con.Close();

        mainForm.refreshDataGridView();
      }
    }

    private void btnBatal_Click(object sender, EventArgs e) {
      txtIDBuku.Text = "";
      txtJudul.Text = "";
      txtPenulis.Text = "";
    }
  }
}
