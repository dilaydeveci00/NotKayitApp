﻿namespace ÖğrenciNotKayıtSistemi
{
    partial class FrmOgrenciDetay
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSinav1 = new System.Windows.Forms.Label();
            this.LblSinav2 = new System.Windows.Forms.Label();
            this.LblSinav3 = new System.Windows.Forms.Label();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.LblNumara = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD  SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMARA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 3:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Durum:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblSinav1
            // 
            this.LblSinav1.AutoSize = true;
            this.LblSinav1.Location = new System.Drawing.Point(246, 140);
            this.LblSinav1.Name = "LblSinav1";
            this.LblSinav1.Size = new System.Drawing.Size(43, 29);
            this.LblSinav1.TabIndex = 7;
            this.LblSinav1.Text = "00";
            // 
            // LblSinav2
            // 
            this.LblSinav2.AutoSize = true;
            this.LblSinav2.Location = new System.Drawing.Point(246, 202);
            this.LblSinav2.Name = "LblSinav2";
            this.LblSinav2.Size = new System.Drawing.Size(43, 29);
            this.LblSinav2.TabIndex = 8;
            this.LblSinav2.Text = "00";
            // 
            // LblSinav3
            // 
            this.LblSinav3.AutoSize = true;
            this.LblSinav3.Location = new System.Drawing.Point(246, 276);
            this.LblSinav3.Name = "LblSinav3";
            this.LblSinav3.Size = new System.Drawing.Size(43, 29);
            this.LblSinav3.TabIndex = 9;
            this.LblSinav3.Text = "00";
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Location = new System.Drawing.Point(246, 402);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(43, 29);
            this.LblOrtalama.TabIndex = 10;
            this.LblOrtalama.Text = "00";
            // 
            // LblNumara
            // 
            this.LblNumara.AutoSize = true;
            this.LblNumara.Location = new System.Drawing.Point(813, 46);
            this.LblNumara.Name = "LblNumara";
            this.LblNumara.Size = new System.Drawing.Size(58, 29);
            this.LblNumara.TabIndex = 11;
            this.LblNumara.Text = "000";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(794, 392);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(77, 29);
            this.LblDurum.TabIndex = 13;
            this.LblDurum.Text = "NULL";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(246, 46);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(77, 29);
            this.LblAdSoyad.TabIndex = 14;
            this.LblAdSoyad.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(976, 652);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblNumara);
            this.Controls.Add(this.LblOrtalama);
            this.Controls.Add(this.LblSinav3);
            this.Controls.Add(this.LblSinav2);
            this.Controls.Add(this.LblSinav1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmOgrenciDetay";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.FrmOgrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSinav1;
        private System.Windows.Forms.Label LblSinav2;
        private System.Windows.Forms.Label LblSinav3;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.Label LblNumara;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Label LblAdSoyad;
    }
}