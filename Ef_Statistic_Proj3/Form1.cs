using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_Statistic_Proj3
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        Ef_StatisticEntities context= new Ef_StatisticEntities();   
        private void Form1_Load(object sender, EventArgs e)
        {
            int categoryCount = context.Category.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            int productCount= context.Product.Count();
            lblProductCount.Text = productCount.ToString();

            int customerCOunt= context.Customer.Count();
            lblCustomerCount.Text = customerCOunt.ToString();

            int orderCount= context.Order.Count();
            lblOrderCount.Text = orderCount.ToString();

            var totalProductStock = context.Product.Sum(x=>x.Stock);
            lblProductStockTotal.Text = totalProductStock.ToString();

            var ortUrunFiyati = context.Product.Average(x => x.Price);
            lblProductAvgPrice.Text=ortUrunFiyati.ToString()+"₺";

            var toplamUrunSayisi = context.Product.Where(x => x.CategoryId == 1).Sum(y=>y.Stock);
            lblTotalFruitCount.Text= toplamUrunSayisi.ToString();

            var gazozToplamIslemStok = context.Product.Where(x => x.Name == "Gazoz").Select(y=>y.Stock).FirstOrDefault();
            var gazozToplamIslemUnitPrice = context.Product.Where(x => x.Name == "Gazoz").Select(y=>y.Price).FirstOrDefault();
            var gazozToplamIslem = gazozToplamIslemStok * gazozToplamIslemUnitPrice;
            lblGazozToplamIslem.Text=gazozToplamIslem.ToString()+" ₺";

            var stokYüzAzUrun = context.Product.Where(x => x.Stock < 100).Count();
            lblStok100AzUrun.Text = stokYüzAzUrun.ToString();

            var meyveId= context.Category.Where(x=>x.CategoryName=="Meyve").Select(a=>a.CategoryId).FirstOrDefault();
            var akifMeyveStok = context.Product.Where(x => x.CategoryId == meyveId && x.Status == true).Sum(y => y.Stock);
            lblAktifMeyveStok.Text=akifMeyveStok.ToString();

            var orderCountFromTurkiye = context.Database.SqlQuery<int>("Select count(*) From [Order] Where CustomerId In (Select CustomerId From Customer Where Country='Türkiye')").FirstOrDefault();
            lblTurkiyeSiparis.Text= orderCountFromTurkiye.ToString();


            var turkishCustomerIds= context.Customer.Where(x=>x.Country=="Türkiye")
                .Select(y=>y.CustomerId).ToList();
            var orderCountFromTurkiyewithEf = context.Order.Count(z=>turkishCustomerIds.Contains(z.CustomerId.Value));
            lblTurkidenSiparisEf.Text= orderCountFromTurkiyewithEf.ToString();

            var orderTotalPriceFruit = context.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) From [Order] o Join Product p On o.ProductId=p.ProductId Join Category c On p.CategoryId=c.CategoryId Where c.CategoryName='Meyve'").FirstOrDefault();
            lblOrderTotalPriceByCategoryIsFruit.Text= orderTotalPriceFruit.ToString()+" ₺";

            var orderTotalPriceFruitEf = (from o in context.Order
                                          join p in context.Product
                                          on o.ProductId equals p.ProductId
                                          join c in context.Category on p.CategoryId equals c.CategoryId
                                          where c.CategoryName == "Meyve"
                                          select o.TotalPrice).Sum();
            lblOrderTotalPriceByCategoryIsFruitWithEf.Text=orderTotalPriceFruitEf.ToString()+" ₺";

            var lastProduct= context.Product.OrderByDescending(x=>x.ProductId).Select(y=>y.Name).FirstOrDefault();
            lblLastProduct.Text= lastProduct.ToString();

            var lastProductCategory = context.Product.OrderByDescending(a => a.ProductId).Select(d => d.Category.CategoryName).FirstOrDefault();
            lblLastProductCategory.Text= lastProductCategory.ToString();

            var activeProductCount = context.Product.Count(a => a.Status == true);
            lblActiveProductCount.Text= activeProductCount.ToString();

            var colaStock = context.Product.Where(a => a.Name == "Kola").Select(l=>l.Stock).FirstOrDefault();
            var productPrice= context.Product.Where(x=>x.Name=="Kola").Select(c=>c.Price).FirstOrDefault();
            var totalColaPrice = colaStock * productPrice;
            lblTotalPriceByCola.Text= totalColaPrice.ToString();

            var sonEklenenMusteriId= context.Order.OrderByDescending(x=>x.OrderId).Select(y=>y.CustomerId).FirstOrDefault();
            var lastCustomerName= context.Customer.Where(a=>a.CustomerId==sonEklenenMusteriId).Select(n=>n.Name).FirstOrDefault();
            lblLastOrderCustomer.Text = lastCustomerName.ToString();

            var countryDifferrentCount= context.Customer.Select(x=>x.Country).Distinct().Count();
            lblDiffrentCount.Text= countryDifferrentCount.ToString();



        }
    }
}
