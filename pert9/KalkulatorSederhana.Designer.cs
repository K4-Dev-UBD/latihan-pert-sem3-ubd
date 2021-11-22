
namespace pert9 {
  partial class KalkulatorSederhana {
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
      this.txtBilangan1 = new System.Windows.Forms.TextBox();
      this.txtBilangan2 = new System.Windows.Forms.TextBox();
      this.txtHasil = new System.Windows.Forms.TextBox();
      this.btnTambah = new System.Windows.Forms.Button();
      this.btnKurang = new System.Windows.Forms.Button();
      this.btnKali = new System.Windows.Forms.Button();
      this.btnBagi = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(312, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Bilangan1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(312, 150);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Bilangan2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(324, 296);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Hasil";
      // 
      // txtBilangan1
      // 
      this.txtBilangan1.Location = new System.Drawing.Point(288, 102);
      this.txtBilangan1.Name = "txtBilangan1";
      this.txtBilangan1.Size = new System.Drawing.Size(100, 20);
      this.txtBilangan1.TabIndex = 3;
      // 
      // txtBilangan2
      // 
      this.txtBilangan2.Location = new System.Drawing.Point(288, 192);
      this.txtBilangan2.Name = "txtBilangan2";
      this.txtBilangan2.Size = new System.Drawing.Size(100, 20);
      this.txtBilangan2.TabIndex = 4;
      // 
      // txtHasil
      // 
      this.txtHasil.Location = new System.Drawing.Point(288, 334);
      this.txtHasil.Name = "txtHasil";
      this.txtHasil.Size = new System.Drawing.Size(100, 20);
      this.txtHasil.TabIndex = 5;
      // 
      // btnTambah
      // 
      this.btnTambah.Location = new System.Drawing.Point(114, 248);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(75, 23);
      this.btnTambah.TabIndex = 6;
      this.btnTambah.Text = "Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // btnKurang
      // 
      this.btnKurang.Location = new System.Drawing.Point(241, 248);
      this.btnKurang.Name = "btnKurang";
      this.btnKurang.Size = new System.Drawing.Size(75, 23);
      this.btnKurang.TabIndex = 7;
      this.btnKurang.Text = "Kurang";
      this.btnKurang.UseVisualStyleBackColor = true;
      this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
      // 
      // btnKali
      // 
      this.btnKali.Location = new System.Drawing.Point(364, 248);
      this.btnKali.Name = "btnKali";
      this.btnKali.Size = new System.Drawing.Size(75, 23);
      this.btnKali.TabIndex = 8;
      this.btnKali.Text = "Kali";
      this.btnKali.UseVisualStyleBackColor = true;
      this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
      // 
      // btnBagi
      // 
      this.btnBagi.Location = new System.Drawing.Point(483, 248);
      this.btnBagi.Name = "btnBagi";
      this.btnBagi.Size = new System.Drawing.Size(75, 23);
      this.btnBagi.TabIndex = 9;
      this.btnBagi.Text = "Bagi";
      this.btnBagi.UseVisualStyleBackColor = true;
      this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(303, 379);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 10;
      this.button5.Text = "Hapus";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // KalkulatorSederhana
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 450);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.btnBagi);
      this.Controls.Add(this.btnKali);
      this.Controls.Add(this.btnKurang);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.txtHasil);
      this.Controls.Add(this.txtBilangan2);
      this.Controls.Add(this.txtBilangan1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "KalkulatorSederhana";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "KalkulatorSederhana";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtBilangan1;
    private System.Windows.Forms.TextBox txtBilangan2;
    private System.Windows.Forms.TextBox txtHasil;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnKurang;
    private System.Windows.Forms.Button btnKali;
    private System.Windows.Forms.Button btnBagi;
    private System.Windows.Forms.Button button5;
  }
}