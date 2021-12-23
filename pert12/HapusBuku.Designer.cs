
namespace pert12 {
  partial class HapusBuku {
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
      this.label2 = new System.Windows.Forms.Label();
      this.txtIdBuku = new System.Windows.Forms.TextBox();
      this.txtJudul = new System.Windows.Forms.TextBox();
      this.btnCari = new System.Windows.Forms.Button();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.btnTutup = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(133, 99);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID Buku";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(133, 166);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Judul";
      // 
      // txtIdBuku
      // 
      this.txtIdBuku.Location = new System.Drawing.Point(238, 99);
      this.txtIdBuku.Name = "txtIdBuku";
      this.txtIdBuku.Size = new System.Drawing.Size(160, 20);
      this.txtIdBuku.TabIndex = 2;
      // 
      // txtJudul
      // 
      this.txtJudul.Location = new System.Drawing.Point(238, 166);
      this.txtJudul.Name = "txtJudul";
      this.txtJudul.ReadOnly = true;
      this.txtJudul.Size = new System.Drawing.Size(241, 20);
      this.txtJudul.TabIndex = 3;
      // 
      // btnCari
      // 
      this.btnCari.Location = new System.Drawing.Point(404, 97);
      this.btnCari.Name = "btnCari";
      this.btnCari.Size = new System.Drawing.Size(106, 25);
      this.btnCari.TabIndex = 6;
      this.btnCari.Text = "Cari";
      this.btnCari.UseVisualStyleBackColor = true;
      this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
      // 
      // btnBatal
      // 
      this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatal.Location = new System.Drawing.Point(259, 269);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(102, 32);
      this.btnBatal.TabIndex = 5;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnHapus.Location = new System.Drawing.Point(112, 269);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(102, 32);
      this.btnHapus.TabIndex = 4;
      this.btnHapus.Text = "Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // btnTutup
      // 
      this.btnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTutup.Location = new System.Drawing.Point(401, 269);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(100, 32);
      this.btnTutup.TabIndex = 7;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
      // 
      // HapusBuku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(622, 399);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnCari);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.txtJudul);
      this.Controls.Add(this.txtIdBuku);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "HapusBuku";
      this.Text = "HapusBuku";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtIdBuku;
    private System.Windows.Forms.TextBox txtJudul;
    private System.Windows.Forms.Button btnCari;
    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnTutup;
  }
}