
namespace pert9 {
  partial class Menu {
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kalkulatorSederhanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.maskTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pilihan1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProgramToolStripMenuItem,
            this.pilihan1ToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(735, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menuProgramToolStripMenuItem
      // 
      this.menuProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalkulatorSederhanaToolStripMenuItem,
            this.maskTextBoxToolStripMenuItem});
      this.menuProgramToolStripMenuItem.Name = "menuProgramToolStripMenuItem";
      this.menuProgramToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
      this.menuProgramToolStripMenuItem.Text = "Menu Program";
      // 
      // kalkulatorSederhanaToolStripMenuItem
      // 
      this.kalkulatorSederhanaToolStripMenuItem.Name = "kalkulatorSederhanaToolStripMenuItem";
      this.kalkulatorSederhanaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
      this.kalkulatorSederhanaToolStripMenuItem.Text = "Kalkulator Sederhana";
      this.kalkulatorSederhanaToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorSederhanaToolStripMenuItem_Click);
      // 
      // maskTextBoxToolStripMenuItem
      // 
      this.maskTextBoxToolStripMenuItem.Name = "maskTextBoxToolStripMenuItem";
      this.maskTextBoxToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
      this.maskTextBoxToolStripMenuItem.Text = "Mask TextBox";
      this.maskTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskTextBoxToolStripMenuItem_Click);
      // 
      // pilihan1ToolStripMenuItem
      // 
      this.pilihan1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.listBoxToolStripMenuItem});
      this.pilihan1ToolStripMenuItem.Name = "pilihan1ToolStripMenuItem";
      this.pilihan1ToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
      this.pilihan1ToolStripMenuItem.Text = "Pilihan 1";
      // 
      // checkBoxToolStripMenuItem
      // 
      this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
      this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.checkBoxToolStripMenuItem.Text = "Check Box";
      this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
      // 
      // listBoxToolStripMenuItem
      // 
      this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
      this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.listBoxToolStripMenuItem.Text = "List Box";
      this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(735, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Menu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menu";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuProgramToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem kalkulatorSederhanaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem maskTextBoxToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pilihan1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}