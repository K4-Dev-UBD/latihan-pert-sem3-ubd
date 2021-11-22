
namespace pert9 {
  partial class CheckBox {
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
      this.cNgoding = new System.Windows.Forms.CheckBox();
      this.cBola = new System.Windows.Forms.CheckBox();
      this.cMusik = new System.Windows.Forms.CheckBox();
      this.cBerenang = new System.Windows.Forms.CheckBox();
      this.cLari = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(139, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Pilih Hobi anda";
      // 
      // cNgoding
      // 
      this.cNgoding.AutoSize = true;
      this.cNgoding.Location = new System.Drawing.Point(85, 95);
      this.cNgoding.Name = "cNgoding";
      this.cNgoding.Size = new System.Drawing.Size(66, 17);
      this.cNgoding.TabIndex = 1;
      this.cNgoding.Text = "Ngoding";
      this.cNgoding.UseVisualStyleBackColor = true;
      // 
      // cBola
      // 
      this.cBola.AutoSize = true;
      this.cBola.Location = new System.Drawing.Point(85, 145);
      this.cBola.Name = "cBola";
      this.cBola.Size = new System.Drawing.Size(47, 17);
      this.cBola.TabIndex = 2;
      this.cBola.Text = "Bola";
      this.cBola.UseVisualStyleBackColor = true;
      // 
      // cMusik
      // 
      this.cMusik.AutoSize = true;
      this.cMusik.Location = new System.Drawing.Point(85, 200);
      this.cMusik.Name = "cMusik";
      this.cMusik.Size = new System.Drawing.Size(54, 17);
      this.cMusik.TabIndex = 3;
      this.cMusik.Text = "Musik";
      this.cMusik.UseVisualStyleBackColor = true;
      // 
      // cBerenang
      // 
      this.cBerenang.AutoSize = true;
      this.cBerenang.Location = new System.Drawing.Point(85, 264);
      this.cBerenang.Name = "cBerenang";
      this.cBerenang.Size = new System.Drawing.Size(72, 17);
      this.cBerenang.TabIndex = 4;
      this.cBerenang.Text = "Berenang";
      this.cBerenang.UseVisualStyleBackColor = true;
      // 
      // cLari
      // 
      this.cLari.AutoSize = true;
      this.cLari.Location = new System.Drawing.Point(85, 320);
      this.cLari.Name = "cLari";
      this.cLari.Size = new System.Drawing.Size(43, 17);
      this.cLari.TabIndex = 5;
      this.cLari.Text = "Lari";
      this.cLari.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(130, 376);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Pilih";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // CheckBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cLari);
      this.Controls.Add(this.cBerenang);
      this.Controls.Add(this.cMusik);
      this.Controls.Add(this.cBola);
      this.Controls.Add(this.cNgoding);
      this.Controls.Add(this.label1);
      this.Name = "CheckBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CheckBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox cNgoding;
    private System.Windows.Forms.CheckBox cBola;
    private System.Windows.Forms.CheckBox cMusik;
    private System.Windows.Forms.CheckBox cBerenang;
    private System.Windows.Forms.CheckBox cLari;
    private System.Windows.Forms.Button button1;
  }
}