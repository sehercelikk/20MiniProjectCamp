using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adonet_Prj1
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        OracleConnection oracleConnection = new OracleConnection("YourDatabaseConnectionString");

        private void btnList_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Select CustomerId, CustomerName,CustomerSurname,Balance, CityName From Customer Inner Join City on City.CityId=Customer.CustomerCity", oracleConnection);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            oracleConnection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("insert into Customer (CustomerId,CustomerName,CustomerSurname,Balance, CustomerCity) values (:customerId, :customerName, :customerSurname,:balance, :customerCity)", oracleConnection);
            command.Parameters.Add("customerId", OracleDbType.Int32).Value = Convert.ToInt32(txtCustomerId.Text);
            command.Parameters.Add("customerName", OracleDbType.Varchar2).Value = txtCustomerName.Text;
            command.Parameters.Add("customerSurname", OracleDbType.Varchar2).Value = txtCustomerSurname.Text;
            command.Parameters.Add("balance", OracleDbType.Int32).Value=Convert.ToInt32(txtCustomerBalance.Text);
            command.Parameters.Add("customerCity", OracleDbType.Varchar2).Value = Convert.ToInt32( customerCity.SelectedValue);

            command.ExecuteNonQuery();
            oracleConnection.Close();
            MessageBox.Show("Müşteri ekleme işlemi başarılı");
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand("Select * From City", oracleConnection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(command);    
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            customerCity.ValueMember="CITYID";
            customerCity.DisplayMember="CITYNAME";
            customerCity.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Delete From Customer Where CustomerId = :cutomerId", oracleConnection);
            command.Parameters.Add(":cityId",OracleDbType.Int32).Value= Convert.ToInt32(txtCustomerId.Text);
            command.ExecuteNonQuery();
            oracleConnection.Close();
            MessageBox.Show("Şehir Başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Update Customer Set CustomerName= :customerName, CustomerSurname= :customerSurname, Balance= :balance, CustomerCity = :customerCity Where CustomerId = :customerId" ,oracleConnection);
            command.Parameters.Add("customerName", OracleDbType.Varchar2).Value=txtCustomerName.Text;
            command.Parameters.Add("customerSurname", OracleDbType.Varchar2).Value = txtCustomerSurname.Text;
            command.Parameters.Add("balance", OracleDbType.Int32).Value = Convert.ToInt32(txtCustomerBalance.Text);
            command.Parameters.Add("customerCity", OracleDbType.Varchar2).Value = Convert.ToInt32(customerCity.SelectedValue);
            command.Parameters.Add("customerId", OracleDbType.Int32).Value= Convert.ToInt32(txtCustomerId.Text);
            command.ExecuteNonQuery();
            oracleConnection.Close();
            MessageBox.Show("Şehir Başarılı bir şekilde güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Select * From Customer Where CustomerName= :customerName OR CustomerSurname = :customerSurname", oracleConnection);
            command.Parameters.Add("customerName", OracleDbType.Varchar2).Value=txtCustomerName.Text;
            command.Parameters.Add("customerSurname", OracleDbType.Varchar2).Value=txtCustomerSurname.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            oracleConnection.Close();
        }
    }
}
