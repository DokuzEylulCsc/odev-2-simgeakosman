﻿namespace UniversiteBilgiSistemi
{
    partial class hoca_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_hoca_sil = new System.Windows.Forms.Button();
            this.btn_hoca_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Ana Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hoca_sil
            // 
            this.btn_hoca_sil.Location = new System.Drawing.Point(167, 136);
            this.btn_hoca_sil.Name = "btn_hoca_sil";
            this.btn_hoca_sil.Size = new System.Drawing.Size(115, 23);
            this.btn_hoca_sil.TabIndex = 30;
            this.btn_hoca_sil.Text = "Öğretim Üyesi Sil";
            this.btn_hoca_sil.UseVisualStyleBackColor = true;
            // 
            // btn_hoca_ekle
            // 
            this.btn_hoca_ekle.Location = new System.Drawing.Point(18, 136);
            this.btn_hoca_ekle.Name = "btn_hoca_ekle";
            this.btn_hoca_ekle.Size = new System.Drawing.Size(120, 23);
            this.btn_hoca_ekle.TabIndex = 29;
            this.btn_hoca_ekle.Text = "Öğretim Üyesi Ekle";
            this.btn_hoca_ekle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Öğretim Üyesi Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Öğretim Üyesi  ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bölüm ID";
            // 
            // hoca_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 235);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_hoca_sil);
            this.Controls.Add(this.btn_hoca_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "hoca_form";
            this.Text = "Öğretim Üyesi İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_hoca_sil;
        private System.Windows.Forms.Button btn_hoca_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}