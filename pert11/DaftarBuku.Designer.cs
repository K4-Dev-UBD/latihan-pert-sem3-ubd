
namespace pert11 {
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTambah = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.btnTutup = new System.Windows.Forms.Button();
      this.buku_ubdDataSet = new pert11.buku_ubdDataSet();
      this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bukuTableAdapter = new pert11.buku_ubdDataSetTableAdapters.BukuTableAdapter();
      this.tableAdapterManager = new pert11.buku_ubdDataSetTableAdapters.TableAdapterManager();
      this.bukuDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.buku_ubdDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bukuDataGridView)).BeginInit();
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
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Location = new System.Drawing.Point(216, 354);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(83, 37);
      this.btnHapus.TabIndex = 2;
      this.btnHapus.Text = "Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(493, 354);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(83, 37);
      this.btnTutup.TabIndex = 3;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
      // 
      // buku_ubdDataSet
      // 
      this.buku_ubdDataSet.DataSetName = "buku_ubdDataSet";
      this.buku_ubdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bukuBindingSource
      // 
      this.bukuBindingSource.DataMember = "Buku";
      this.bukuBindingSource.DataSource = this.buku_ubdDataSet;
      // 
      // bukuTableAdapter
      // 
      this.bukuTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BukuTableAdapter = this.bukuTableAdapter;
      this.tableAdapterManager.UpdateOrder = pert11.buku_ubdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // bukuDataGridView
      // 
      this.bukuDataGridView.AutoGenerateColumns = false;
      this.bukuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.bukuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
      this.bukuDataGridView.DataSource = this.bukuBindingSource;
      this.bukuDataGridView.Location = new System.Drawing.Point(77, 99);
      this.bukuDataGridView.Name = "bukuDataGridView";
      this.bukuDataGridView.Size = new System.Drawing.Size(343, 220);
      this.bukuDataGridView.TabIndex = 5;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Judul";
      this.dataGridViewTextBoxColumn2.HeaderText = "Judul";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Penulis";
      this.dataGridViewTextBoxColumn3.HeaderText = "Penulis";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // DaftarBuku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 450);
      this.Controls.Add(this.bukuDataGridView);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.label1);
      this.Name = "DaftarBuku";
      this.Text = "DaftarBuku";
      this.Load += new System.EventHandler(this.DaftarBuku_Load);
      ((System.ComponentModel.ISupportInitialize)(this.buku_ubdDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bukuDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnTutup;
    private buku_ubdDataSet buku_ubdDataSet;
    private System.Windows.Forms.BindingSource bukuBindingSource;
    private buku_ubdDataSetTableAdapters.BukuTableAdapter bukuTableAdapter;
    private buku_ubdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridView bukuDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
  }
}