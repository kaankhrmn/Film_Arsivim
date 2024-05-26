using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KAAN\SQLEXPRESS;Initial Catalog=FilmArşivim;Integrated Security=True");

        //bo kodu datagriedview üzerinden de yapabiliriz.
        void Filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD,LINK TBLFILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwFilmListesi.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmArşivimDataSet.TBLFILMLER' table. You can move, or remove it, as needed.
            this.tBLFILMLERTableAdapter.Fill(this.filmArşivimDataSet.TBLFILMLER);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD,KATEGORI,LINK) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("film eklendi");
            this.tBLFILMLERTableAdapter.Fill(this.filmArşivimDataSet.TBLFILMLER);
        }

        private void dgwFilmListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgwFilmListesi.SelectedCells[0].RowIndex;
            string link = dgwFilmListesi.Rows[secilen].Cells[3].Value.ToString();
            webView1.Url = link;
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Kaan Kahraman tarafından yapılmıştır.");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int a =rnd.Next(0,256);
            //int b = rnd.Next(0, 256);
            //int c = rnd.Next(0, 256);
            //Color renk = Color.FromArgb(a,b,c);
            //this.BackColor = renk;


            Color[] renkler = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
            int uzunluk = renkler.Length;
            Random rnd = new Random();
            int sayi = rnd.Next(0, uzunluk);
            Color color = renkler[sayi];
            this.BackColor = color;

        }
    }
}
