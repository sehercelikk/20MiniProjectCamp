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
using System.Xml.Linq;

namespace Adonet_Prj1
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        OracleConnection oracleConnection = new OracleConnection("YourDataBaseConnectionString");
        private void btnList_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Select * From City", oracleConnection);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            oracleConnection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("insert into City (CityId, CityName, CityCountry) values (:cityId, :cityName,:cityCountry)", oracleConnection);
            command.Parameters.Add("cityId", OracleDbType.Int32).Value = Convert.ToInt32(txtCityId.Text);
            command.Parameters.Add("cityName", OracleDbType.Varchar2).Value = txtCityName.Text;
            command.Parameters.Add("cityCountry", OracleDbType.Varchar2).Value = txtCityCountry.Text;

            command.ExecuteNonQuery();
            oracleConnection.Close();
            MessageBox.Show("Kayıt başarıyla eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Delete From City Where CityId= : cityId", oracleConnection);
            command.Parameters.Add("cityId", OracleDbType.Int32).Value=Convert.ToInt32(txtCityId.Text);
            command.ExecuteNonQuery();
            oracleConnection.Close();
            MessageBox.Show("Şehir Başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("UPDATE City SET CityName= :cityName,CityCountry= :cityCountry WHERE CityId = :cityId", oracleConnection);
            command.Parameters.Add("cityName", OracleDbType.Varchar2).Value=txtCityName.Text;
            command.Parameters.Add("cityCountry", OracleDbType.Varchar2).Value=txtCityCountry.Text;
            command.Parameters.Add("cityId", OracleDbType.Int32).Value = Convert.ToInt32(txtCityId.Text);
            command.ExecuteNonQuery();
            oracleConnection.Close();
            MessageBox.Show("Şehir Başarıyla Güncellendi", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            oracleConnection.Open();
            OracleCommand command = new OracleCommand("Select * From City Where CityName= :cityName", oracleConnection);
            command.Parameters.Add("cityName", OracleDbType.Varchar2).Value=txtCityName.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable tbl= new DataTable();
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            oracleConnection.Close();
        }
    }
}

