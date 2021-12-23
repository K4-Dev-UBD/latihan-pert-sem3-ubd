
namespace pert12 {
  partial class TambahBuku {
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
      this.txtIDBuku = new System.Windows.Forms.TextBox();
      this.txtJudul = new System.Windows.Forms.TextBox();
      this.txtPenulis = new System.Windows.Forms.TextBox();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.btnBatal = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(116, 108);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID Buku";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(116, 163);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(78, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Judul Buku";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(116, 218);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Penulis";
      // 
      // txtIDBuku
      // 
      this.txtIDBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtIDBuku.Location = new System.Drawing.Point(206, 105);
      this.txtIDBuku.Name = "txtIDBuku";
      this.txtIDBuku.Size = new System.Drawing.Size(194, 23);
      this.txtIDBuku.TabIndex = 3;
      // 
      // txtJudul
      // 
      this.txtJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtJudul.Location = new System.Drawing.Point(206, 160);
      this.txtJudul.Name = "txtJudul";
      this.txtJudul.Size = new System.Drawing.Size(194, 23);
      this.txtJudul.TabIndex = 4;
      // 
      // txtPenulis
      // 
      this.txtPenulis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPenulis.Location = new System.Drawing.Point(206, 214);
      this.txtPenulis.Name = "txtPenulis";
      this.txtPenulis.Size = new System.Drawing.Size(194, 23);
      this.txtPenulis.TabIndex = 5;
      // 
      // btnSimpan
      // 
      this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSimpan.Location = new System.Drawing.Point(119, 306);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(102, 40);
      this.btnSimpan.TabIndex = 6;
      this.btnSimpan.Text = "Simpan";
      this.btnSimpan.UseVisualStyleBackColor = true;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // btnBatal
      // 
      this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatal.Location = new System.Drawing.Point(279, 306);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(102, 40);
      this.btnBatal.TabIndex = 7;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // TambahBuku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(516, 450);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.txtPenulis);
      this.Controls.Add(this.txtJudul);
      this.Controls.Add(this.txtIDBuku);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "TambahBuku";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "TambahBuku";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtIDBuku;
    private System.Windows.Forms.TextBox txtJudul;
    private System.Windows.Forms.TextBox txtPenulis;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.Button btnBatal;
  }
}