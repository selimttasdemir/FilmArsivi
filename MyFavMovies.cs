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

namespace FilmArsivi
{
    public partial class MyFavMovies : Form
    {
        public MyFavMovies()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SELIM-TASDEMIR;Initial Catalog=FilmArsivi;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select FilmAd, Kategori, Durum, link from tblFilmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmAd.Text != "" && txtKategori.Text != "" && txtLink.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tblFilmler(FilmAd,Kategori,Link) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
                komut.Parameters.AddWithValue("@p2", txtKategori.Text);
                komut.Parameters.AddWithValue("@p3", txtLink.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Film Eklendi..");
                filmler();
            }
            else
            {
                MessageBox.Show("Kutular Boş Geçilemez !");
            }
        }

        private void TamEkran_Click(object sender, EventArgs e)
        {
            Tamekran te = new Tamekran();

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            te.Film = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            te.Show();
            te.FormBorderStyle = FormBorderStyle.None;
            te.WindowState = FormWindowState.Maximized;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);

        }

        private void Hakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje SELIM TASDEMIR tarafından Tasarlanmıştır.","Bilgi" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Tema_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x, y, z;
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);

            this.BackColor = Color.FromArgb(x, y, z);
        }
    }
}
