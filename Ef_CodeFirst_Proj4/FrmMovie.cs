using Ef_CodeFirst_Proj4.DAL.Context;
using Ef_CodeFirst_Proj4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_CodeFirst_Proj4
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }

        MovieContext context=new MovieContext();
        void KategoriListe()
        {
            var categories = context.Categories.ToList();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
            cmbKategori.DataSource = categories;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            KategoriListe();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Title=txtFilmAdi.Text;
            movie.Description=txtAciklama.Text;
            movie.CreatedDate=DateTime.Parse(mtbIzlenmeTarih.Text);
            movie.CategoryId=int.Parse(cmbKategori.SelectedValue.ToString());
            movie.Duration=int.Parse(txtFilmSuresi.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("Ekleme işlemi Başarılı");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var updateId=int.Parse(txtProductId.Text);
            var values = context.Movies.Find(updateId);
            values.Title = txtFilmAdi.Text;
            values.Description = txtAciklama.Text;
            values.CreatedDate = DateTime.Parse(mtbIzlenmeTarih.Text);
            values.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            values.Duration = int.Parse(txtFilmSuresi.Text);
            context.SaveChanges();
            MessageBox.Show("Guncelleme işlemi başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var deleteId=int.Parse(txtProductId.Text);
            var values = context.Movies.Find(deleteId);
            context.Movies.Remove(values);
            context.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var values= context.Movies.Where(x=>x.Title==txtFilmAdi.Text).ToList();
            dataGridView1.DataSource = values;

        }

        private void btnKategoriIleListele_Click(object sender, EventArgs e)
        {
            var values = context.Movies
                .Join(context.Categories,
                movie => movie.CategoryId,
                category => category.CategoryId,
                (movie, category) => new
                {
                    MovieId = movie.MovieId,
                    Title = movie.Title,
                    Description = movie.Description,
                    Duration = movie.Duration,
                    CategoryName = category.CategoryName,
                }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
