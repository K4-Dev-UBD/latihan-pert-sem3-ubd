
namespace pert11 {
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.btnCari = new System.Windows.Forms.Button();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(138, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID Buku";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(138, 172);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Judul";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(243, 105);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(160, 20);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(243, 172);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(241, 20);
      this.textBox2.TabIndex = 3;
      // 
      // btnCari
      // 
      this.btnCari.Location = new System.Drawing.Point(409, 103);
      this.btnCari.Name = "btnCari";
      this.btnCari.Size = new System.Drawing.Size(106, 25);
      this.btnCari.TabIndex = 6;
      this.btnCari.Text = "Cari";
      this.btnCari.UseVisualStyleBackColor = true;
      // 
      // btnBatal
      // 
      this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatal.Location = new System.Drawing.Point(336, 275);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(102, 32);
      this.btnBatal.TabIndex = 5;
      this.btnBatal.Text = "Batal";
      this.btnBatal.UseVisualStyleBackColor = true;
      // 
      // btnHapus
      // 
      this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnHapus.Location = new System.Drawing.Point(189, 275);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(102, 32);
      this.btnHapus.TabIndex = 4;
      this.btnHapus.Text = "Hapus";
      this.btnHapus.UseVisualStyleBackColor = true;
      // 
      // HapusBuku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(622, 399);
      this.Controls.Add(this.btnCari);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
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
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button btnCari;
    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnHapus;
  }
}