namespace FilmKiralama
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
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.tbxGunlukUcret = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxYonetmen = new System.Windows.Forms.TextBox();
            this.tbxFilmIsim = new System.Windows.Forms.TextBox();
            this.lblGunlukUcret = new System.Windows.Forms.Label();
            this.lblYonetmen = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnKiralık = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.gbxKirala = new System.Windows.Forms.GroupBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.cbxKiralikGun = new System.Windows.Forms.ComboBox();
            this.cbxKiralikFilm = new System.Windows.Forms.ComboBox();
            this.tbxKiralikSoyisim = new System.Windows.Forms.TextBox();
            this.tbxKiralikIsim = new System.Windows.Forms.TextBox();
            this.lblKiralikGun = new System.Windows.Forms.Label();
            this.lblKiralikFilm = new System.Windows.Forms.Label();
            this.lblKiralikSoyisim = new System.Windows.Forms.Label();
            this.lblKiralikIsim = new System.Windows.Forms.Label();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbxFilmSil = new System.Windows.Forms.ComboBox();
            this.lblFilmSil = new System.Windows.Forms.Label();
            this.gbxEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            this.gbxKirala.SuspendLayout();
            this.gbxSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.tbxGunlukUcret);
            this.gbxEkle.Controls.Add(this.btnEkle);
            this.gbxEkle.Controls.Add(this.tbxYonetmen);
            this.gbxEkle.Controls.Add(this.tbxFilmIsim);
            this.gbxEkle.Controls.Add(this.lblGunlukUcret);
            this.gbxEkle.Controls.Add(this.lblYonetmen);
            this.gbxEkle.Controls.Add(this.lblFilm);
            this.gbxEkle.Location = new System.Drawing.Point(12, 213);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(270, 226);
            this.gbxEkle.TabIndex = 19;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Film Ekle";
            // 
            // tbxGunlukUcret
            // 
            this.tbxGunlukUcret.Location = new System.Drawing.Point(106, 105);
            this.tbxGunlukUcret.Name = "tbxGunlukUcret";
            this.tbxGunlukUcret.Size = new System.Drawing.Size(120, 22);
            this.tbxGunlukUcret.TabIndex = 17;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(142, 147);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 24);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxYonetmen
            // 
            this.tbxYonetmen.Location = new System.Drawing.Point(106, 66);
            this.tbxYonetmen.Name = "tbxYonetmen";
            this.tbxYonetmen.Size = new System.Drawing.Size(120, 22);
            this.tbxYonetmen.TabIndex = 13;
            // 
            // tbxFilmIsim
            // 
            this.tbxFilmIsim.Location = new System.Drawing.Point(106, 28);
            this.tbxFilmIsim.Name = "tbxFilmIsim";
            this.tbxFilmIsim.Size = new System.Drawing.Size(121, 22);
            this.tbxFilmIsim.TabIndex = 12;
            // 
            // lblGunlukUcret
            // 
            this.lblGunlukUcret.AutoSize = true;
            this.lblGunlukUcret.Location = new System.Drawing.Point(9, 112);
            this.lblGunlukUcret.Name = "lblGunlukUcret";
            this.lblGunlukUcret.Size = new System.Drawing.Size(83, 16);
            this.lblGunlukUcret.TabIndex = 10;
            this.lblGunlukUcret.Text = "Günlük Ücret";
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.AutoSize = true;
            this.lblYonetmen.Location = new System.Drawing.Point(9, 69);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(91, 16);
            this.lblYonetmen.TabIndex = 9;
            this.lblYonetmen.Text = "Yönetmen Adı";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(15, 31);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(59, 16);
            this.lblFilm.TabIndex = 8;
            this.lblFilm.Text = "Film İsmi";
            // 
            // btnKiralık
            // 
            this.btnKiralık.Location = new System.Drawing.Point(711, 392);
            this.btnKiralık.Name = "btnKiralık";
            this.btnKiralık.Size = new System.Drawing.Size(154, 42);
            this.btnKiralık.TabIndex = 18;
            this.btnKiralık.Text = "Kiralık Filmleri Göster";
            this.btnKiralık.UseVisualStyleBackColor = true;
            this.btnKiralık.Click += new System.EventHandler(this.btnRentalMovies_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(590, 392);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(115, 43);
            this.btnFilm.TabIndex = 17;
            this.btnFilm.Text = "Filmleri Göster";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // dgwMovies
            // 
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovies.Location = new System.Drawing.Point(12, 12);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.RowHeadersWidth = 51;
            this.dgwMovies.RowTemplate.Height = 24;
            this.dgwMovies.Size = new System.Drawing.Size(853, 195);
            this.dgwMovies.TabIndex = 15;
            // 
            // gbxKirala
            // 
            this.gbxKirala.Controls.Add(this.btnKirala);
            this.gbxKirala.Controls.Add(this.cbxKiralikGun);
            this.gbxKirala.Controls.Add(this.cbxKiralikFilm);
            this.gbxKirala.Controls.Add(this.tbxKiralikSoyisim);
            this.gbxKirala.Controls.Add(this.tbxKiralikIsim);
            this.gbxKirala.Controls.Add(this.lblKiralikGun);
            this.gbxKirala.Controls.Add(this.lblKiralikFilm);
            this.gbxKirala.Controls.Add(this.lblKiralikSoyisim);
            this.gbxKirala.Controls.Add(this.lblKiralikIsim);
            this.gbxKirala.Location = new System.Drawing.Point(299, 213);
            this.gbxKirala.Name = "gbxKirala";
            this.gbxKirala.Size = new System.Drawing.Size(270, 226);
            this.gbxKirala.TabIndex = 14;
            this.gbxKirala.TabStop = false;
            this.gbxKirala.Text = "Film Kirala";
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(142, 198);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(85, 24);
            this.btnKirala.TabIndex = 16;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cbxKiralikGun
            // 
            this.cbxKiralikGun.FormattingEnabled = true;
            this.cbxKiralikGun.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbxKiralikGun.Location = new System.Drawing.Point(106, 155);
            this.cbxKiralikGun.Name = "cbxKiralikGun";
            this.cbxKiralikGun.Size = new System.Drawing.Size(121, 24);
            this.cbxKiralikGun.TabIndex = 15;
            // 
            // cbxKiralikFilm
            // 
            this.cbxKiralikFilm.FormattingEnabled = true;
            this.cbxKiralikFilm.Location = new System.Drawing.Point(106, 112);
            this.cbxKiralikFilm.Name = "cbxKiralikFilm";
            this.cbxKiralikFilm.Size = new System.Drawing.Size(121, 24);
            this.cbxKiralikFilm.TabIndex = 14;
            // 
            // tbxKiralikSoyisim
            // 
            this.tbxKiralikSoyisim.Location = new System.Drawing.Point(106, 66);
            this.tbxKiralikSoyisim.Name = "tbxKiralikSoyisim";
            this.tbxKiralikSoyisim.Size = new System.Drawing.Size(120, 22);
            this.tbxKiralikSoyisim.TabIndex = 13;
            // 
            // tbxKiralikIsim
            // 
            this.tbxKiralikIsim.Location = new System.Drawing.Point(106, 28);
            this.tbxKiralikIsim.Name = "tbxKiralikIsim";
            this.tbxKiralikIsim.Size = new System.Drawing.Size(121, 22);
            this.tbxKiralikIsim.TabIndex = 12;
            // 
            // lblKiralikGun
            // 
            this.lblKiralikGun.AutoSize = true;
            this.lblKiralikGun.Location = new System.Drawing.Point(15, 155);
            this.lblKiralikGun.Name = "lblKiralikGun";
            this.lblKiralikGun.Size = new System.Drawing.Size(31, 16);
            this.lblKiralikGun.TabIndex = 11;
            this.lblKiralikGun.Text = "Gün";
            // 
            // lblKiralikFilm
            // 
            this.lblKiralikFilm.AutoSize = true;
            this.lblKiralikFilm.Location = new System.Drawing.Point(15, 112);
            this.lblKiralikFilm.Name = "lblKiralikFilm";
            this.lblKiralikFilm.Size = new System.Drawing.Size(32, 16);
            this.lblKiralikFilm.TabIndex = 10;
            this.lblKiralikFilm.Text = "Film";
            // 
            // lblKiralikSoyisim
            // 
            this.lblKiralikSoyisim.AutoSize = true;
            this.lblKiralikSoyisim.Location = new System.Drawing.Point(15, 72);
            this.lblKiralikSoyisim.Name = "lblKiralikSoyisim";
            this.lblKiralikSoyisim.Size = new System.Drawing.Size(55, 16);
            this.lblKiralikSoyisim.TabIndex = 9;
            this.lblKiralikSoyisim.Text = "Soyisim";
            // 
            // lblKiralikIsim
            // 
            this.lblKiralikIsim.AutoSize = true;
            this.lblKiralikIsim.Location = new System.Drawing.Point(15, 31);
            this.lblKiralikIsim.Name = "lblKiralikIsim";
            this.lblKiralikIsim.Size = new System.Drawing.Size(31, 16);
            this.lblKiralikIsim.TabIndex = 8;
            this.lblKiralikIsim.Text = "İsim";
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.btnSil);
            this.gbxSil.Controls.Add(this.cbxFilmSil);
            this.gbxSil.Controls.Add(this.lblFilmSil);
            this.gbxSil.Location = new System.Drawing.Point(590, 222);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Size = new System.Drawing.Size(275, 127);
            this.gbxSil.TabIndex = 23;
            this.gbxSil.TabStop = false;
            this.gbxSil.Text = "Film Sil";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(161, 78);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxFilmSil
            // 
            this.cbxFilmSil.FormattingEnabled = true;
            this.cbxFilmSil.Location = new System.Drawing.Point(115, 31);
            this.cbxFilmSil.Name = "cbxFilmSil";
            this.cbxFilmSil.Size = new System.Drawing.Size(121, 24);
            this.cbxFilmSil.TabIndex = 24;
            // 
            // lblFilmSil
            // 
            this.lblFilmSil.AutoSize = true;
            this.lblFilmSil.Location = new System.Drawing.Point(19, 34);
            this.lblFilmSil.Name = "lblFilmSil";
            this.lblFilmSil.Size = new System.Drawing.Size(55, 16);
            this.lblFilmSil.TabIndex = 23;
            this.lblFilmSil.Text = "Film Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 460);
            this.Controls.Add(this.gbxSil);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.btnKiralık);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.dgwMovies);
            this.Controls.Add(this.gbxKirala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).EndInit();
            this.gbxKirala.ResumeLayout(false);
            this.gbxKirala.PerformLayout();
            this.gbxSil.ResumeLayout(false);
            this.gbxSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxYonetmen;
        private System.Windows.Forms.TextBox tbxFilmIsim;
        private System.Windows.Forms.Label lblGunlukUcret;
        private System.Windows.Forms.Label lblYonetmen;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Button btnKiralık;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.DataGridView dgwMovies;
        private System.Windows.Forms.GroupBox gbxKirala;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ComboBox cbxKiralikGun;
        private System.Windows.Forms.ComboBox cbxKiralikFilm;
        private System.Windows.Forms.TextBox tbxKiralikSoyisim;
        private System.Windows.Forms.TextBox tbxKiralikIsim;
        private System.Windows.Forms.Label lblKiralikGun;
        private System.Windows.Forms.Label lblKiralikFilm;
        private System.Windows.Forms.Label lblKiralikSoyisim;
        private System.Windows.Forms.Label lblKiralikIsim;
        private System.Windows.Forms.TextBox tbxGunlukUcret;
        private System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cbxFilmSil;
        private System.Windows.Forms.Label lblFilmSil;
    }
}

