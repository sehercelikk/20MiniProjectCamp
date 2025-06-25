namespace Ef_CodeFirst_Proj4
{
    partial class FrmMovie
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmSuresi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbIzlenmeTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnKategoriIleListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(677, 128);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 19;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(557, 128);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(421, 128);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(293, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "İzlenme Tarihi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 279);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(181, 128);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(213, 49);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(167, 20);
            this.txtFilmAdi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Film Adı:";
            // 
            // txtFilmSuresi
            // 
            this.txtFilmSuresi.Location = new System.Drawing.Point(213, 80);
            this.txtFilmSuresi.Name = "txtFilmSuresi";
            this.txtFilmSuresi.Size = new System.Drawing.Size(167, 20);
            this.txtFilmSuresi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Film Süresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kategori:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(213, 23);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(167, 20);
            this.txtProductId.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Id:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(492, 20);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(167, 20);
            this.txtAciklama.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Açıklama:";
            // 
            // mtbIzlenmeTarih
            // 
            this.mtbIzlenmeTarih.Location = new System.Drawing.Point(492, 53);
            this.mtbIzlenmeTarih.Mask = "00/00/0000";
            this.mtbIzlenmeTarih.Name = "mtbIzlenmeTarih";
            this.mtbIzlenmeTarih.Size = new System.Drawing.Size(167, 20);
            this.mtbIzlenmeTarih.TabIndex = 28;
            this.mtbIzlenmeTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(492, 80);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(167, 21);
            this.cmbKategori.TabIndex = 29;
            // 
            // btnKategoriIleListele
            // 
            this.btnKategoriIleListele.BackColor = System.Drawing.Color.White;
            this.btnKategoriIleListele.Location = new System.Drawing.Point(62, 128);
            this.btnKategoriIleListele.Name = "btnKategoriIleListele";
            this.btnKategoriIleListele.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriIleListele.TabIndex = 30;
            this.btnKategoriIleListele.Text = "Listele2";
            this.btnKategoriIleListele.UseVisualStyleBackColor = false;
            this.btnKategoriIleListele.Click += new System.EventHandler(this.btnKategoriIleListele_Click);
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.btnKategoriIleListele);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.mtbIzlenmeTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilmSuresi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmSuresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbIzlenmeTarih;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnKategoriIleListele;
    }
}