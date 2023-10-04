namespace hafta6_odev1_randevuDefteri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kayıtlar = new System.Windows.Forms.ListBox();
            this.txt_isimSoyisim = new System.Windows.Forms.TextBox();
            this.lbl_randevuTarihi = new System.Windows.Forms.Label();
            this.lbl_isimSoyisim = new System.Windows.Forms.Label();
            this.txt_randevuTarihi = new System.Windows.Forms.TextBox();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.bttn_kaydet = new System.Windows.Forms.Button();
            this.pb_cloud = new System.Windows.Forms.PictureBox();
            this.lbl_kayit = new System.Windows.Forms.Label();
            this.lbl_tamam = new System.Windows.Forms.Label();
            this.bttn_refresh = new System.Windows.Forms.Button();
            this.bttn_sorgu = new System.Windows.Forms.Button();
            this.lbl_sorgu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cloud)).BeginInit();
            this.SuspendLayout();
            // 
            // Kayıtlar
            // 
            this.Kayıtlar.FormattingEnabled = true;
            this.Kayıtlar.ItemHeight = 16;
            this.Kayıtlar.Location = new System.Drawing.Point(411, 44);
            this.Kayıtlar.Name = "Kayıtlar";
            this.Kayıtlar.Size = new System.Drawing.Size(357, 372);
            this.Kayıtlar.TabIndex = 1;
            // 
            // txt_isimSoyisim
            // 
            this.txt_isimSoyisim.Location = new System.Drawing.Point(210, 47);
            this.txt_isimSoyisim.Name = "txt_isimSoyisim";
            this.txt_isimSoyisim.Size = new System.Drawing.Size(151, 22);
            this.txt_isimSoyisim.TabIndex = 2;
            // 
            // lbl_randevuTarihi
            // 
            this.lbl_randevuTarihi.AutoSize = true;
            this.lbl_randevuTarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_randevuTarihi.Location = new System.Drawing.Point(18, 168);
            this.lbl_randevuTarihi.Name = "lbl_randevuTarihi";
            this.lbl_randevuTarihi.Size = new System.Drawing.Size(121, 19);
            this.lbl_randevuTarihi.TabIndex = 3;
            this.lbl_randevuTarihi.Text = "Randevu Tarihi";
            // 
            // lbl_isimSoyisim
            // 
            this.lbl_isimSoyisim.AutoSize = true;
            this.lbl_isimSoyisim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_isimSoyisim.Location = new System.Drawing.Point(18, 48);
            this.lbl_isimSoyisim.Name = "lbl_isimSoyisim";
            this.lbl_isimSoyisim.Size = new System.Drawing.Size(115, 19);
            this.lbl_isimSoyisim.TabIndex = 4;
            this.lbl_isimSoyisim.Text = "İsim - Soyisim";
            // 
            // txt_randevuTarihi
            // 
            this.txt_randevuTarihi.Location = new System.Drawing.Point(253, 168);
            this.txt_randevuTarihi.Name = "txt_randevuTarihi";
            this.txt_randevuTarihi.Size = new System.Drawing.Size(108, 22);
            this.txt_randevuTarihi.TabIndex = 5;
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(210, 108);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(151, 22);
            this.txt_TC.TabIndex = 6;
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_TC.Location = new System.Drawing.Point(18, 108);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(164, 19);
            this.lbl_TC.TabIndex = 7;
            this.lbl_TC.Text = "TC Kimlik Numarası";
            // 
            // bttn_kaydet
            // 
            this.bttn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_kaydet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kaydet.Location = new System.Drawing.Point(241, 210);
            this.bttn_kaydet.Name = "bttn_kaydet";
            this.bttn_kaydet.Size = new System.Drawing.Size(120, 30);
            this.bttn_kaydet.TabIndex = 8;
            this.bttn_kaydet.Text = "Yeni Kayıt";
            this.bttn_kaydet.UseVisualStyleBackColor = true;
            this.bttn_kaydet.Click += new System.EventHandler(this.bttn_kaydet_Click);
            this.bttn_kaydet.MouseEnter += new System.EventHandler(this.bttn_kaydet_MouseEnter);
            this.bttn_kaydet.MouseLeave += new System.EventHandler(this.bttn_kaydet_MouseLeave);
            // 
            // pb_cloud
            // 
            this.pb_cloud.Image = ((System.Drawing.Image)(resources.GetObject("pb_cloud.Image")));
            this.pb_cloud.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_cloud.InitialImage")));
            this.pb_cloud.Location = new System.Drawing.Point(430, 12);
            this.pb_cloud.Name = "pb_cloud";
            this.pb_cloud.Size = new System.Drawing.Size(58, 29);
            this.pb_cloud.TabIndex = 9;
            this.pb_cloud.TabStop = false;
            // 
            // lbl_kayit
            // 
            this.lbl_kayit.AutoSize = true;
            this.lbl_kayit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit.Location = new System.Drawing.Point(532, 18);
            this.lbl_kayit.Name = "lbl_kayit";
            this.lbl_kayit.Size = new System.Drawing.Size(148, 23);
            this.lbl_kayit.TabIndex = 10;
            this.lbl_kayit.Text = "Mevcut Kayıtlar";
            // 
            // lbl_tamam
            // 
            this.lbl_tamam.AutoSize = true;
            this.lbl_tamam.Location = new System.Drawing.Point(210, 251);
            this.lbl_tamam.Name = "lbl_tamam";
            this.lbl_tamam.Size = new System.Drawing.Size(0, 16);
            this.lbl_tamam.TabIndex = 12;
            // 
            // bttn_refresh
            // 
            this.bttn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bttn_refresh.Image")));
            this.bttn_refresh.Location = new System.Drawing.Point(730, 12);
            this.bttn_refresh.Name = "bttn_refresh";
            this.bttn_refresh.Size = new System.Drawing.Size(38, 27);
            this.bttn_refresh.TabIndex = 13;
            this.bttn_refresh.UseVisualStyleBackColor = true;
            this.bttn_refresh.Click += new System.EventHandler(this.bttn_refresh_Click);
            // 
            // bttn_sorgu
            // 
            this.bttn_sorgu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_sorgu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_sorgu.Location = new System.Drawing.Point(22, 210);
            this.bttn_sorgu.Name = "bttn_sorgu";
            this.bttn_sorgu.Size = new System.Drawing.Size(89, 30);
            this.bttn_sorgu.TabIndex = 14;
            this.bttn_sorgu.Text = "Sorgula";
            this.bttn_sorgu.UseVisualStyleBackColor = true;
            this.bttn_sorgu.Click += new System.EventHandler(this.bttn_sorgu_Click);
            // 
            // lbl_sorgu
            // 
            this.lbl_sorgu.AutoSize = true;
            this.lbl_sorgu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sorgu.Location = new System.Drawing.Point(131, 215);
            this.lbl_sorgu.Name = "lbl_sorgu";
            this.lbl_sorgu.Size = new System.Drawing.Size(0, 19);
            this.lbl_sorgu.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.lbl_sorgu);
            this.Controls.Add(this.bttn_sorgu);
            this.Controls.Add(this.bttn_refresh);
            this.Controls.Add(this.lbl_tamam);
            this.Controls.Add(this.lbl_kayit);
            this.Controls.Add(this.pb_cloud);
            this.Controls.Add(this.bttn_kaydet);
            this.Controls.Add(this.lbl_TC);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.txt_randevuTarihi);
            this.Controls.Add(this.lbl_isimSoyisim);
            this.Controls.Add(this.lbl_randevuTarihi);
            this.Controls.Add(this.txt_isimSoyisim);
            this.Controls.Add(this.Kayıtlar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Randevu Defteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Kayıtlar;
        private System.Windows.Forms.TextBox txt_isimSoyisim;
        private System.Windows.Forms.Label lbl_randevuTarihi;
        private System.Windows.Forms.Label lbl_isimSoyisim;
        private System.Windows.Forms.TextBox txt_randevuTarihi;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Button bttn_kaydet;
        private System.Windows.Forms.PictureBox pb_cloud;
        private System.Windows.Forms.Label lbl_kayit;
        private System.Windows.Forms.Label lbl_tamam;
        private System.Windows.Forms.Button bttn_refresh;
        private System.Windows.Forms.Button bttn_sorgu;
        private System.Windows.Forms.Label lbl_sorgu;
    }
}

