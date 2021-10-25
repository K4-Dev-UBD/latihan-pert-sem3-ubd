
namespace pert7
{
    partial class DemoMaskTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.msNIM = new System.Windows.Forms.MaskedTextBox();
            this.msNama = new System.Windows.Forms.MaskedTextBox();
            this.msTglLahir = new System.Windows.Forms.MaskedTextBox();
            this.msJenisKelamin = new System.Windows.Forms.MaskedTextBox();
            this.msNoTelp = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tgl Lahir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. Telp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(160, 311);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 31);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Submit";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // msNIM
            // 
            this.msNIM.Location = new System.Drawing.Point(160, 69);
            this.msNIM.Name = "msNIM";
            this.msNIM.Size = new System.Drawing.Size(226, 20);
            this.msNIM.TabIndex = 11;
            // 
            // msNama
            // 
            this.msNama.Location = new System.Drawing.Point(160, 110);
            this.msNama.Name = "msNama";
            this.msNama.Size = new System.Drawing.Size(226, 20);
            this.msNama.TabIndex = 12;
            // 
            // msTglLahir
            // 
            this.msTglLahir.Location = new System.Drawing.Point(160, 151);
            this.msTglLahir.Name = "msTglLahir";
            this.msTglLahir.Size = new System.Drawing.Size(226, 20);
            this.msTglLahir.TabIndex = 13;
            // 
            // msJenisKelamin
            // 
            this.msJenisKelamin.Location = new System.Drawing.Point(160, 195);
            this.msJenisKelamin.Name = "msJenisKelamin";
            this.msJenisKelamin.Size = new System.Drawing.Size(226, 20);
            this.msJenisKelamin.TabIndex = 14;
            // 
            // msNoTelp
            // 
            this.msNoTelp.Location = new System.Drawing.Point(160, 240);
            this.msNoTelp.Name = "msNoTelp";
            this.msNoTelp.Size = new System.Drawing.Size(226, 20);
            this.msNoTelp.TabIndex = 15;
            // 
            // DemoMaskTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 393);
            this.Controls.Add(this.msNoTelp);
            this.Controls.Add(this.msJenisKelamin);
            this.Controls.Add(this.msTglLahir);
            this.Controls.Add(this.msNama);
            this.Controls.Add(this.msNIM);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DemoMaskTextBox";
            this.Text = "DemoMaskTextBox";
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
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox msNIM;
        private System.Windows.Forms.MaskedTextBox msNama;
        private System.Windows.Forms.MaskedTextBox msTglLahir;
        private System.Windows.Forms.MaskedTextBox msJenisKelamin;
        private System.Windows.Forms.MaskedTextBox msNoTelp;
    }
}