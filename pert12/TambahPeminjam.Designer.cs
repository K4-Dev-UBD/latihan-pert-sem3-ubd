
namespace pert12 {
  partial class TambahPeminjam {
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
      this.label4 = new System.Windows.Forms.Label();
      this.txtIdPeminjam = new System.Windows.Forms.TextBox();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.txtAlamat = new System.Windows.Forms.TextBox();
      this.txtTelp = new System.Windows.Forms.TextBox();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnTutup = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(73, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID Peminjam";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(73, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nama";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(73, 170);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Alamat";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(73, 290);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "No Telp";
      // 
      // txtIdPeminjam
      // 
      this.txtIdPeminjam.Location = new System.Drawing.Point(195, 55);
      this.txtIdPeminjam.Name = "txtIdPeminjam";
      this.txtIdPeminjam.Size = new System.Drawing.Size(258, 20);
      this.txtIdPeminjam.TabIndex = 4;
      // 
      // txtNama
      // 
      this.txtNama.Location = new System.Drawing.Point(195, 108);
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(258, 20);
      this.txtNama.TabIndex = 5;
      // 
      // txtAlamat
      // 
      this.txtAlamat.Location = new System.Drawing.Point(195, 171);
      this.txtAlamat.Multiline = true;
      this.txtAlamat.Name = "txtAlamat";
      this.txtAlamat.Size = new System.Drawing.Size(258, 97);
      this.txtAlamat.TabIndex = 6;
      // 
      // txtTelp
      // 
      this.txtTelp.Location = new System.Drawing.Point(195, 291);
      this.txtTelp.Name = "txtTelp";
      this.txtTelp.Size = new System.Drawing.Size(258, 20);
      this.txtTelp.TabIndex = 7;
      // 
      // btnSimpan
      // 
      this.btnSimpan.Location = new System.Drawing.Point(77, 355);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(97, 41);
      this.btnSimpan.TabIndex = 8;
      this.btnSimpan.Text = "Simpan";
      this.btnSimpan.UseVisualStyleBackColor = true;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // btnBatal
      // 
      this.btnBatal.Location = new System.Drawing.Point(216, 355);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(97, 41);
      this.btnBatal.TabIndex = 9;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // btnTutup
      // 
      this.btnTutup.Location = new System.Drawing.Point(355, 355);
      this.btnTutup.Name = "btnTutup";
      this.btnTutup.Size = new System.Drawing.Size(97, 41);
      this.btnTutup.TabIndex = 10;
      this.btnTutup.Text = "Tutup";
      this.btnTutup.UseVisualStyleBackColor = true;
      this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
      // 
      // TambahPeminjam
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(527, 450);
      this.Controls.Add(this.btnTutup);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.txtTelp);
      this.Controls.Add(this.txtAlamat);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.txtIdPeminjam);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "TambahPeminjam";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "TambahPeminjam";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtIdPeminjam;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.TextBox txtAlamat;
    private System.Windows.Forms.TextBox txtTelp;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnTutup;
  }
}