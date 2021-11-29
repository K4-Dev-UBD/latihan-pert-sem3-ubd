
namespace pert10 {
  partial class FormUtama {
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
      this.btnPeminjam = new System.Windows.Forms.Button();
      this.btnPinjam = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label1.Location = new System.Drawing.Point(165, 126);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(146, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "Perpus UBD";
      // 
      // btnTambah
      // 
      this.btnTambah.BackColor = System.Drawing.Color.Chartreuse;
      this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTambah.Location = new System.Drawing.Point(57, 204);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(97, 37);
      this.btnTambah.TabIndex = 1;
      this.btnTambah.Text = "Tambah";
      this.btnTambah.UseVisualStyleBackColor = false;
      // 
      // btnPeminjam
      // 
      this.btnPeminjam.BackColor = System.Drawing.Color.Aquamarine;
      this.btnPeminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPeminjam.Location = new System.Drawing.Point(185, 204);
      this.btnPeminjam.Name = "btnPeminjam";
      this.btnPeminjam.Size = new System.Drawing.Size(97, 37);
      this.btnPeminjam.TabIndex = 2;
      this.btnPeminjam.Text = "Peminjam";
      this.btnPeminjam.UseVisualStyleBackColor = false;
      // 
      // btnPinjam
      // 
      this.btnPinjam.BackColor = System.Drawing.Color.LightSeaGreen;
      this.btnPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPinjam.Location = new System.Drawing.Point(313, 204);
      this.btnPinjam.Name = "btnPinjam";
      this.btnPinjam.Size = new System.Drawing.Size(97, 37);
      this.btnPinjam.TabIndex = 3;
      this.btnPinjam.Text = "Pinjam Buku";
      this.btnPinjam.UseVisualStyleBackColor = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::pert10.Properties.Resources.ubd_icon;
      this.pictureBox1.Location = new System.Drawing.Point(184, 39);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 84);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // FormUtama
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.IndianRed;
      this.ClientSize = new System.Drawing.Size(467, 351);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.btnPinjam);
      this.Controls.Add(this.btnPeminjam);
      this.Controls.Add(this.btnTambah);
      this.Controls.Add(this.label1);
      this.Name = "FormUtama";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Aplikasi Perpus UBD";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnPeminjam;
    private System.Windows.Forms.Button btnPinjam;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

