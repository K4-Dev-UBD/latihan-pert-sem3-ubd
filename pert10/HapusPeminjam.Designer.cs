
namespace pert10 {
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
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
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
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(181, 192);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(272, 20);
      this.textBox2.TabIndex = 10;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(181, 125);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(160, 20);
      this.textBox1.TabIndex = 9;
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
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(346, 295);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(108, 32);
      this.button1.TabIndex = 14;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // HapusPeminjam
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnCari);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
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
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
  }
}