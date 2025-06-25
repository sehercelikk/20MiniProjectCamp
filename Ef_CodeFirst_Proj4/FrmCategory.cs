using Ef_CodeFirst_Proj4.DAL.Context;
using Ef_CodeFirst_Proj4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_CodeFirst_Proj4
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        MovieContext context=new MovieContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            var category= context.Categories.ToList();
            dataGridView1.DataSource = category;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtName.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id =int.Parse(txtId.Text);
            var categoryUpdate = context.Categories.Find(id);
            categoryUpdate.CategoryName = txtName.Text;
            context.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var deleteId= int.Parse(txtId.Text);
            var categoryDelete = context.Categories.Find(deleteId);
            context.Categories.Remove(categoryDelete);
            context.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var values= context.Categories.Where(x=>x.CategoryName==txtName.Text).ToList();
            dataGridView1.DataSource= values;
        }
    }
}
