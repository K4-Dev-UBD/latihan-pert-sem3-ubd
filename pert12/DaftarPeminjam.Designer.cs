
namespace pert12 {
  partial class DaftarPeminjam {
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnTambah = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.btnTutup = new System.Windows.Forms.Button();
      this.buku_ubdDataSet1 = new pert12.buku_ubdDataSet1();
      this.peminjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.peminjamTableAdapter = new pert12.buku_ubdDataSet1TableAdapters.PeminjamTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.buku_ubdDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(61, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(127, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Daftar Peminjam";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.peminjamBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(65, 114);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(447, 210);
      this.dataGridView1.TabIndex = 1;
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(65, 333);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(103, 40);
      this.btnTambah.TabIndex = 2;
      this.btnTambah.Text = "Tambah ";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Location = new System.Drawing.Point(182, 333);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(103, 40);
      this.btnHapus.TabIndex = 3;
      this.btnHapus.Text = "Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(398, 333);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(103, 40);
      this.btnTutup.TabIndex = 4;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
      // 
      // buku_ubdDataSet1
      // 
      this.buku_ubdDataSet1.DataSetName = "buku_ubdDataSet1";
      this.buku_ubdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // peminjamBindingSource
      // 
      this.peminjamBindingSource.DataMember = "Peminjam";
      this.peminjamBindingSource.DataSource = this.buku_ubdDataSet1;
      // 
      // peminjamTableAdapter
      // 
      this.peminjamTableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // namaDataGridViewTextBoxColumn
      // 
      this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
      this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
      this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
      // 
      // alamatDataGridViewTextBoxColumn
      // 
      this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
      this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
      this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
      // 
      // telpDataGridViewTextBoxColumn
      // 
      this.telpDataGridViewTextBoxColumn.DataPropertyName = "telp";
      this.telpDataGridViewTextBoxColumn.HeaderText = "telp";
      this.telpDataGridViewTextBoxColumn.Name = "telpDataGridViewTextBoxColumn";
      // 
      // DaftarPeminjam
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(563, 450);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label1);
      this.Name = "DaftarPeminjam";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DaftarPeminjam";
      this.Load += new System.EventHandler(this.DaftarPeminjam_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.buku_ubdDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnTutup;
    private buku_ubdDataSet1 buku_ubdDataSet1;
    private System.Windows.Forms.BindingSource peminjamBindingSource;
    private buku_ubdDataSet1TableAdapters.PeminjamTableAdapter peminjamTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
  }
}