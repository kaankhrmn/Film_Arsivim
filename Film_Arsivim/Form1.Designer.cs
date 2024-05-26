namespace Film_Arsivim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.btnHakkımızda = new System.Windows.Forms.Button();
            this.btnTamEkran = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwFilmListesi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KATEGORI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURUM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kATEGORIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLFILMLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmArşivimDataSet = new Film_Arsivim.FilmArşivimDataSet();
            this.tBLFILMLERTableAdapter = new Film_Arsivim.FilmArşivimDataSetTableAdapters.TBLFILMLERTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFILMLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmArşivimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 85);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(452, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 53);
            this.label4.TabIndex = 5;
            this.label4.Text = "SİNEMA KOLTUK YAZILIM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1159, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 527);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Controls.Add(this.btnRenkDegistir);
            this.groupBox4.Controls.Add(this.btnHakkımızda);
            this.groupBox4.Controls.Add(this.btnTamEkran);
            this.groupBox4.Location = new System.Drawing.Point(7, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 249);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(5, 197);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(304, 41);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(6, 152);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(304, 41);
            this.btnRenkDegistir.TabIndex = 0;
            this.btnRenkDegistir.Text = "RENK DEĞİŞTİR";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // btnHakkımızda
            // 
            this.btnHakkımızda.Location = new System.Drawing.Point(6, 107);
            this.btnHakkımızda.Name = "btnHakkımızda";
            this.btnHakkımızda.Size = new System.Drawing.Size(304, 41);
            this.btnHakkımızda.TabIndex = 0;
            this.btnHakkımızda.Text = "HAKKIMIZDA";
            this.btnHakkımızda.UseVisualStyleBackColor = true;
            this.btnHakkımızda.Click += new System.EventHandler(this.btnHakkımızda_Click);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.Location = new System.Drawing.Point(6, 62);
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Size = new System.Drawing.Size(304, 41);
            this.btnTamEkran.TabIndex = 0;
            this.btnTamEkran.Text = "TAM EKRAN";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(111, 199);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(205, 42);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(111, 149);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(205, 35);
            this.txtLink.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Link:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(111, 108);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(205, 35);
            this.txtKategori.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori:";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(111, 67);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(205, 35);
            this.txtFilmAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webControl1);
            this.groupBox2.Location = new System.Drawing.Point(760, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 527);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(3, 31);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(492, 493);
            this.webControl1.TabIndex = 0;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwFilmListesi);
            this.groupBox3.Location = new System.Drawing.Point(340, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 527);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Listesi";
            // 
            // dgwFilmListesi
            // 
            this.dgwFilmListesi.AutoGenerateColumns = false;
            this.dgwFilmListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AD,
            this.KATEGORI,
            this.LINK,
            this.DURUM,
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.kATEGORIDataGridViewTextBoxColumn,
            this.lINKDataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dgwFilmListesi.DataSource = this.tBLFILMLERBindingSource;
            this.dgwFilmListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFilmListesi.Location = new System.Drawing.Point(3, 31);
            this.dgwFilmListesi.Name = "dgwFilmListesi";
            this.dgwFilmListesi.RowHeadersWidth = 62;
            this.dgwFilmListesi.RowTemplate.Height = 28;
            this.dgwFilmListesi.Size = new System.Drawing.Size(408, 493);
            this.dgwFilmListesi.TabIndex = 0;
            this.dgwFilmListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFilmListesi_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // AD
            // 
            this.AD.DataPropertyName = "AD";
            this.AD.HeaderText = "AD";
            this.AD.MinimumWidth = 8;
            this.AD.Name = "AD";
            this.AD.Width = 150;
            // 
            // KATEGORI
            // 
            this.KATEGORI.DataPropertyName = "KATEGORI";
            this.KATEGORI.HeaderText = "KATEGORI";
            this.KATEGORI.MinimumWidth = 8;
            this.KATEGORI.Name = "KATEGORI";
            this.KATEGORI.Width = 150;
            // 
            // LINK
            // 
            this.LINK.DataPropertyName = "LINK";
            this.LINK.HeaderText = "LINK";
            this.LINK.MinimumWidth = 8;
            this.LINK.Name = "LINK";
            this.LINK.Width = 150;
            // 
            // DURUM
            // 
            this.DURUM.DataPropertyName = "DURUM";
            this.DURUM.HeaderText = "DURUM";
            this.DURUM.MinimumWidth = 8;
            this.DURUM.Name = "DURUM";
            this.DURUM.Width = 150;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 150;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kATEGORIDataGridViewTextBoxColumn
            // 
            this.kATEGORIDataGridViewTextBoxColumn.DataPropertyName = "KATEGORI";
            this.kATEGORIDataGridViewTextBoxColumn.HeaderText = "KATEGORI";
            this.kATEGORIDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kATEGORIDataGridViewTextBoxColumn.Name = "kATEGORIDataGridViewTextBoxColumn";
            this.kATEGORIDataGridViewTextBoxColumn.Width = 150;
            // 
            // lINKDataGridViewTextBoxColumn
            // 
            this.lINKDataGridViewTextBoxColumn.DataPropertyName = "LINK";
            this.lINKDataGridViewTextBoxColumn.HeaderText = "LINK";
            this.lINKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lINKDataGridViewTextBoxColumn.Name = "lINKDataGridViewTextBoxColumn";
            this.lINKDataGridViewTextBoxColumn.Width = 150;
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            this.dURUMDataGridViewCheckBoxColumn.Width = 150;
            // 
            // tBLFILMLERBindingSource
            // 
            this.tBLFILMLERBindingSource.DataMember = "TBLFILMLER";
            this.tBLFILMLERBindingSource.DataSource = this.filmArşivimDataSet;
            // 
            // filmArşivimDataSet
            // 
            this.filmArşivimDataSet.DataSetName = "FilmArşivimDataSet";
            this.filmArşivimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLFILMLERTableAdapter
            // 
            this.tBLFILMLERTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1272, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFILMLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmArşivimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHakkımızda;
        private System.Windows.Forms.Button btnTamEkran;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.DataGridView dgwFilmListesi;
        private System.Windows.Forms.Label label4;
        private FilmArşivimDataSet filmArşivimDataSet;
        private System.Windows.Forms.BindingSource tBLFILMLERBindingSource;
        private FilmArşivimDataSetTableAdapters.TBLFILMLERTableAdapter tBLFILMLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KATEGORI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DURUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kATEGORIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lINKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
    }
}

