
namespace pert9 {
  partial class MaskTextBox {
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
      this.label5 = new System.Windows.Forms.Label();
      this.msNIM = new System.Windows.Forms.MaskedTextBox();
      this.msNama = new System.Windows.Forms.MaskedTextBox();
      this.msTglLahir = new System.Windows.Forms.MaskedTextBox();
      this.msJenisKelamin = new System.Windows.Forms.MaskedTextBox();
      this.msNoTelp = new System.Windows.Forms.MaskedTextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(164, 83);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "NIM";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(164, 132);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nama";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(164, 188);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Tgl Lahir";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(164, 246);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(71, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Jenis Kelamin";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(164, 304);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(45, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "No Telp";
      // 
      // msNIM
      // 
      this.msNIM.Location = new System.Drawing.Point(308, 80);
      this.msNIM.Name = "msNIM";
      this.msNIM.Size = new System.Drawing.Size(100, 20);
      this.msNIM.TabIndex = 10;
      // 
      // msNama
      // 
      this.msNama.Location = new System.Drawing.Point(308, 132);
      this.msNama.Name = "msNama";
      this.msNama.Size = new System.Drawing.Size(100, 20);
      this.msNama.TabIndex = 11;
      // 
      // msTglLahir
      // 
      this.msTglLahir.Location = new System.Drawing.Point(308, 188);
      this.msTglLahir.Name = "msTglLahir";
      this.msTglLahir.Size = new System.Drawing.Size(100, 20);
      this.msTglLahir.TabIndex = 12;
      // 
      // msJenisKelamin
      // 
      this.msJenisKelamin.Location = new System.Drawing.Point(308, 239);
      this.msJenisKelamin.Name = "msJenisKelamin";
      this.msJenisKelamin.Size = new System.Drawing.Size(100, 20);
      this.msJenisKelamin.TabIndex = 13;
      // 
      // msNoTelp
      // 
      this.msNoTelp.Location = new System.Drawing.Point(308, 301);
      this.msNoTelp.Name = "msNoTelp";
      this.msNoTelp.Size = new System.Drawing.Size(100, 20);
      this.msNoTelp.TabIndex = 14;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(235, 360);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 15;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // MaskTextBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(573, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.msNoTelp);
      this.Controls.Add(this.msJenisKelamin);
      this.Controls.Add(this.msTglLahir);
      this.Controls.Add(this.msNama);
      this.Controls.Add(this.msNIM);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "MaskTextBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MaskTextBox";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.MaskedTextBox msNIM;
    private System.Windows.Forms.MaskedTextBox msNama;
    private System.Windows.Forms.MaskedTextBox msTglLahir;
    private System.Windows.Forms.MaskedTextBox msJenisKelamin;
    private System.Windows.Forms.MaskedTextBox msNoTelp;
    private System.Windows.Forms.Button button1;
  }
}