
namespace Odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.txtMetinOkuma = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBoxKelime = new System.Windows.Forms.ListBox();
            this.btnStackeOku = new System.Windows.Forms.Button();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSecilenYol = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(59, 267);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(151, 29);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // txtMetinOkuma
            // 
            this.txtMetinOkuma.Location = new System.Drawing.Point(59, 44);
            this.txtMetinOkuma.Multiline = true;
            this.txtMetinOkuma.Name = "txtMetinOkuma";
            this.txtMetinOkuma.Size = new System.Drawing.Size(472, 217);
            this.txtMetinOkuma.TabIndex = 1;
            this.txtMetinOkuma.TextChanged += new System.EventHandler(this.txtMetinOkuma_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // listBoxKelime
            // 
            this.listBoxKelime.ItemHeight = 20;
            this.listBoxKelime.Location = new System.Drawing.Point(551, 44);
            this.listBoxKelime.Name = "listBoxKelime";
            this.listBoxKelime.Size = new System.Drawing.Size(308, 364);
            this.listBoxKelime.TabIndex = 2;
            this.listBoxKelime.SelectedIndexChanged += new System.EventHandler(this.listBoxKelime_SelectedIndexChanged);
            // 
            // btnStackeOku
            // 
            this.btnStackeOku.Location = new System.Drawing.Point(59, 305);
            this.btnStackeOku.Name = "btnStackeOku";
            this.btnStackeOku.Size = new System.Drawing.Size(151, 29);
            this.btnStackeOku.TabIndex = 4;
            this.btnStackeOku.Text = "Stack’e Oku";
            this.btnStackeOku.UseVisualStyleBackColor = true;
            this.btnStackeOku.Click += new System.EventHandler(this.btnStackeOku_Click);
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(59, 340);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(151, 29);
            this.btnAgacaAktar.TabIndex = 6;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hash Tablo Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Okunan Metin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kelime Kullanım Sıklığı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seçilen Dosyanın Yolu :";
            // 
            // lblSecilenYol
            // 
            this.lblSecilenYol.ForeColor = System.Drawing.Color.Red;
            this.lblSecilenYol.Location = new System.Drawing.Point(225, 415);
            this.lblSecilenYol.Name = "lblSecilenYol";
            this.lblSecilenYol.Size = new System.Drawing.Size(634, 20);
            this.lblSecilenYol.TabIndex = 11;
            this.lblSecilenYol.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(59, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Halil Erdem ÜNGÖR - 200601072";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSecilenYol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.btnStackeOku);
            this.Controls.Add(this.listBoxKelime);
            this.Controls.Add(this.txtMetinOkuma);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "METİN YAZARI BELİRLEME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.TextBox txtMetinOkuma;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox listBoxKelime;
        private System.Windows.Forms.Button btnStackeOku;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecilenYol;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
    }
}

