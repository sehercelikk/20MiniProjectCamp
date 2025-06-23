using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_DbFrist_Proj2
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        Ef_DbFirstEntities1 context= new Ef_DbFirstEntities1();
        void CategoryList()
        {
            var values = context.Category.ToList();
            dataGridView1.DataSource = values;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtName.Text;
            context.Category.Add(category);
            context.SaveChanges();
            CategoryList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(txtId.Text);
            var value = context.Category.Find(id);
            context.Category.Remove(value);
            context.SaveChanges();
            CategoryList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(txtId.Text);
            var value = context.Category.Find(id);
            value.CategoryName = txtName.Text;
            context.SaveChanges();
            CategoryList();

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
