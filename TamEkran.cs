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
    public partial class Tamekran : Form
    {
        public Tamekran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SELIM-TASDEMIR;Initial Catalog=FilmArsivi;Integrated Security=True");
        public string Film;
        private void Tamekran_Load(object sender, EventArgs e)
        {
            this.Text = Film.ToString();
            wb2.Navigate(this.Text);
        }
    }
}
