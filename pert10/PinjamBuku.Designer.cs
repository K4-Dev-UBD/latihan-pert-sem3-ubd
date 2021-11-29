
namespace pert10 {
  partial class PinjamBuku {
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtIdBuku = new System.Windows.Forms.TextBox();
      this.txtIdPeminjam = new System.Windows.Forms.TextBox();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnTutup = new System.Windows.Forms.Button();
      this.btnCari = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(89, 64);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID Buku";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(89, 133);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "ID Peminjam";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(89, 202);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Nama";
      // 
      // txtIdBuku
      // 
      this.txtIdBuku.Location = new System.Drawing.Point(203, 66);
      this.txtIdBuku.Name = "txtIdBuku";
      this.txtIdBuku.Size = new System.Drawing.Size(163, 20);
      this.txtIdBuku.TabIndex = 3;
      // 
      // txtIdPeminjam
      // 
      this.txtIdPeminjam.Location = new System.Drawing.Point(203, 130);
      this.txtIdPeminjam.Name = "txtIdPeminjam";
      this.txtIdPeminjam.Size = new System.Drawing.Size(280, 20);
      this.txtIdPeminjam.TabIndex = 4;
      // 
      // btnSimpan
      // 
      this.btnSimpan.Location = new System.Drawing.Point(88, 338);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(75, 23);
      this.btnSimpan.TabIndex = 6;
      this.btnSimpan.Text = "Simpan";
      this.btnSimpan.UseVisualStyleBackColor = true;
      // 
      // btnBatal
      // 
      this.btnBatal.Location = new System.Drawing.Point(241, 338);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(75, 23);
      this.btnBatal.TabIndex = 7;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(394, 338);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(75, 23);
      this.btnTutup.TabIndex = 8;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      // 
      // btnCari
      // 
      this.btnCari.Location = new System.Drawing.Point(395, 64);
      this.btnCari.Name = "btnCari";
      this.btnCari.Size = new System.Drawing.Size(75, 23);
      this.btnCari.TabIndex = 9;
      this.btnCari.Text = "Cari";
      this.btnCari.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(89, 271);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(88, 20);
      this.label4.TabIndex = 10;
      this.label4.Text = "Judul Buku";
      // 
      // PinjamBuku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(558, 424);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnCari);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.txtIdPeminjam);
      this.Controls.Add(this.txtIdBuku);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "PinjamBuku";
      this.Text = "PinjamBuku";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtIdBuku;
    private System.Windows.Forms.TextBox txtIdPeminjam;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnTutup;
    private System.Windows.Forms.Button btnCari;
    private System.Windows.Forms.Label label4;
  }
}