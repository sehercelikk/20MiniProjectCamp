using Dapper;
using Dapper_Proj5.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_Proj5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Server=YoureServerName;Initial Catalog=Db5Project_20;Integrated Security=true");

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select Count(*) From Categories";
            var count= await connection.ExecuteScalarAsync<int>(query);
            lblcategoryCount.Text ="Toplam Kategori ayısı:" + count;

            string query1 = "Select Count(*) From Products";
            var count2 = await connection.ExecuteScalarAsync<int>(query1);
            lblProductCount.Text = "Toplam Ürün ayısı:" + count2;

            string query2 = "Select Avg(UnitsInStock) From Products";
            var avgProduct= await connection.ExecuteScalarAsync<int>(query2);
            lblAvgProductStock.Text="Ortalama Ürün Sayısı: " + avgProduct;

            string query3 = "Select Sum(UnitPrice) From Products Where CategoryId=(Select CategoryId From Categories Where CategoryName='SeaFood')";
            var totaplPrice= await connection.ExecuteScalarAsync<decimal>(query3);
            lblSeaFoodProductTotalPrice.Text = "Deniz Ürünleri Toplam Fiyatı: " + totaplPrice;

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * From Categories";
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            string query = "Insert into Categories(CategoryName, Description) values (@p1,@p2)";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", txtAd.Text);
            parameters.Add("@p2", txtAciklama.Text);
            await connection.ExecuteAsync(query, parameters);


        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            string query = "Update Categories Set CategoryName=@cName, Description=@des Where CategoryID=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@cName", txtAd.Text);
            parameters.Add("@des", txtAciklama.Text);
            parameters.Add("@id", txtId.Text);
            await connection.ExecuteAsync (query, parameters);
        }

        private async void bntSil_Click(object sender, EventArgs e)
        {
            string query = "Delete From Categories Where CategoryID=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id",txtId.Text);
            await connection.ExecuteAsync(query,parameters);
        }
    }
}
