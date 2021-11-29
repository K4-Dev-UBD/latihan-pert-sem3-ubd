
namespace pert10 {
  partial class DaftarBuku {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.btnTambah = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.btnTutup = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(73, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Daftar Buku";
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(77, 354);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(128, 37);
      this.btnTambah.TabIndex = 1;
      this.btnTambah.Text = "Tambah Buku";
      this.btnTambah.UseVisualStyleBackColor = true;
      // 
      // btnHapus
      // 
      this.btnHapus.Location = new System.Drawing.Point(216, 354);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(83, 37);
      this.btnHapus.TabIndex = 2;
      this.btnHapus.Text = "Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(493, 354);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(83, 37);
      this.btnTutup.TabIndex = 3;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(76, 105);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(494, 228);
      this.dataGridView1.TabIndex = 4;
      // 
      // DaftarBuku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 450);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.label1);
      this.Name = "DaftarBuku";
      this.Text = "DaftarBuku";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnTutup;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}