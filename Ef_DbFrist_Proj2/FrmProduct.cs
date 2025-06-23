using System;
using System.Collections;
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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        Ef_DbFirstEntities1 context = new Ef_DbFirstEntities1();
        void ProductList()
        {
            var values = context.Product.ToList();
            dataGridView1.DataSource = values;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Price=decimal.Parse(txtPrice.Text);
            product.Stock=int.Parse(txtStock.Text);
            product.Name=txtName.Text;
            product.CategoryId= int.Parse(cmbCategory.SelectedValue.ToString());
            context.Product.Add(product);
            context.SaveChanges();
            ProductList();

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values=context.Category.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource= values;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtId.Text);
            var value = context.Product.Find(id);
            context.Product.Remove(value);
            context.SaveChanges();
            ProductList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var value = context.Product.Find(int.Parse(txtId.Text));
            value.Name=txtName.Text;
            value.ProductId = int.Parse(cmbCategory.SelectedValue.ToString());
            value.Price=decimal.Parse(txtPrice.Text);
            value.Stock=int.Parse(txtStock.Text);
            value.Stock = int.Parse(txtStock.Text);

            context.SaveChanges();
            ProductList();
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            var values = context.Product.Join(context.Category,
                product => product.CategoryId,
                category => category.CategoryId,
                (product, category) => new
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Price = product.Price,
                    Stock = product.Stock,
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                }
                ).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var values= context.Product.Where(a=>a.Name==txtName.Text).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
