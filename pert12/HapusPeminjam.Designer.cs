﻿
namespace pert12 {
  partial class HapusPeminjam {
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
      this.btnCari = new System.Windows.Forms.Button();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.txtIdPeminjam = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTutup = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCari
      // 
      this.btnCari.Location = new System.Drawing.Point(347, 123);
      this.btnCari.Name = "btnCari";
      this.btnCari.Size = new System.Drawing.Size(106, 25);
      this.btnCari.TabIndex = 13;
      this.btnCari.Text = "Cari";
      this.btnCari.UseVisualStyleBackColor = true;
      this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
      // 
      // btnBatal
      // 
      this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatal.Location = new System.Drawing.Point(205, 295);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(102, 32);
      this.btnBatal.TabIndex = 12;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnHapus.Location = new System.Drawing.Point(64, 295);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(102, 32);
      this.btnHapus.TabIndex = 11;
      this.btnHapus.Text = "Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // txtNama
      // 
      this.txtNama.Location = new System.Drawing.Point(181, 192);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(272, 20);
      this.txtNama.TabIndex = 10;
      // 
      // txtIdPeminjam
      // 
      this.txtIdPeminjam.Location = new System.Drawing.Point(181, 125);
      this.txtIdPeminjam.Name = "txtIdPeminjam";
      this.txtIdPeminjam.Size = new System.Drawing.Size(160, 20);
      this.txtIdPeminjam.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(65, 192);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 20);
      this.label2.TabIndex = 8;
      this.label2.Text = "Nama";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(65, 125);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 20);
      this.label1.TabIndex = 7;
      this.label1.Text = "ID Peminjam";
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(346, 295);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(108, 32);
      this.btnTutup.TabIndex = 14;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
      // 
      // HapusPeminjam
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 450);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnCari);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.txtIdPeminjam);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "HapusPeminjam";
      this.Text = "HapusPeminjam";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCari;
    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.TextBox txtIdPeminjam;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTutup;
  }
}