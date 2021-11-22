
namespace pert9 {
  partial class ListBox {
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
      this.txtItem = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.listKiri = new System.Windows.Forms.ListBox();
      this.listKanan = new System.Windows.Forms.ListBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(56, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Elemen Baru";
      // 
      // txtItem
      // 
      this.txtItem.Location = new System.Drawing.Point(46, 61);
      this.txtItem.Name = "txtItem";
      this.txtItem.Size = new System.Drawing.Size(100, 20);
      this.txtItem.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(362, 47);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Tambah";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // listKiri
      // 
      this.listKiri.FormattingEnabled = true;
      this.listKiri.Location = new System.Drawing.Point(46, 142);
      this.listKiri.Name = "listKiri";
      this.listKiri.Size = new System.Drawing.Size(185, 251);
      this.listKiri.TabIndex = 3;
      // 
      // listKanan
      // 
      this.listKanan.FormattingEnabled = true;
      this.listKanan.Location = new System.Drawing.Point(371, 142);
      this.listKanan.Name = "listKanan";
      this.listKanan.Size = new System.Drawing.Size(185, 251);
      this.listKanan.TabIndex = 4;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(264, 199);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = ">";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(264, 234);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 6;
      this.button3.Text = ">>";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(264, 273);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 7;
      this.button4.Text = "<";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(264, 312);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 8;
      this.button5.Text = "<<";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // ListBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 450);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.listKanan);
      this.Controls.Add(this.listKiri);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtItem);
      this.Controls.Add(this.label1);
      this.Name = "ListBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ListBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtItem;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listKiri;
    private System.Windows.Forms.ListBox listKanan;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
  }
}