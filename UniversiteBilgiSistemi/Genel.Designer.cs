namespace UniversiteBilgiSistemi
{
    partial class Genel_form
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
            this.btn_ogr = new System.Windows.Forms.Button();
            this.btn_fakulte = new System.Windows.Forms.Button();
            this.btn_ders = new System.Windows.Forms.Button();
            this.btn_hoca = new System.Windows.Forms.Button();
            this.btn_bolum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ogr
            // 
            this.btn_ogr.Location = new System.Drawing.Point(132, 38);
            this.btn_ogr.Name = "btn_ogr";
            this.btn_ogr.Size = new System.Drawing.Size(96, 68);
            this.btn_ogr.TabIndex = 0;
            this.btn_ogr.Text = "Öğrenci İşlemleri";
            this.btn_ogr.UseVisualStyleBackColor = true;
            this.btn_ogr.Click += new System.EventHandler(this.btn_ogr_Click);
            // 
            // btn_fakulte
            // 
            this.btn_fakulte.Location = new System.Drawing.Point(12, 38);
            this.btn_fakulte.Name = "btn_fakulte";
            this.btn_fakulte.Size = new System.Drawing.Size(97, 68);
            this.btn_fakulte.TabIndex = 1;
            this.btn_fakulte.Text = "Fakülte İşlemleri";
            this.btn_fakulte.UseVisualStyleBackColor = true;
            this.btn_fakulte.Click += new System.EventHandler(this.btn_fakulte_Click);
            // 
            // btn_ders
            // 
            this.btn_ders.Location = new System.Drawing.Point(269, 38);
            this.btn_ders.Name = "btn_ders";
            this.btn_ders.Size = new System.Drawing.Size(93, 68);
            this.btn_ders.TabIndex = 2;
            this.btn_ders.Text = "Ders İşlemleri";
            this.btn_ders.UseVisualStyleBackColor = true;
            this.btn_ders.Click += new System.EventHandler(this.btn_ders_Click);
            // 
            // btn_hoca
            // 
            this.btn_hoca.Location = new System.Drawing.Point(423, 38);
            this.btn_hoca.Name = "btn_hoca";
            this.btn_hoca.Size = new System.Drawing.Size(92, 68);
            this.btn_hoca.TabIndex = 3;
            this.btn_hoca.Text = "Öğretim Üyesi İşlemleri";
            this.btn_hoca.UseVisualStyleBackColor = true;
            this.btn_hoca.Click += new System.EventHandler(this.btn_hoca_Click);
            // 
            // btn_bolum
            // 
            this.btn_bolum.Location = new System.Drawing.Point(144, 148);
            this.btn_bolum.Name = "btn_bolum";
            this.btn_bolum.Size = new System.Drawing.Size(185, 96);
            this.btn_bolum.TabIndex = 0;
            this.btn_bolum.Text = "Bölüm İşlemleri";
            this.btn_bolum.Click += new System.EventHandler(this.btn_bolum_Click);
            // 
            // Genel_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 275);
            this.Controls.Add(this.btn_bolum);
            this.Controls.Add(this.btn_hoca);
            this.Controls.Add(this.btn_ders);
            this.Controls.Add(this.btn_fakulte);
            this.Controls.Add(this.btn_ogr);
            this.Name = "Genel_form";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Genel_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogr;
        private System.Windows.Forms.Button btn_fakulte;
        private System.Windows.Forms.Button btn_ders;
        private System.Windows.Forms.Button btn_hoca;
        private System.Windows.Forms.Button btn_bolum;
    }
}

