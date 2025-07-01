using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace RapitApi_Proj8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        decimal dolar = 0;
        decimal euro = 0;
        decimal sterlin = 0;
        private async void Form1_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "key" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDolar.Text = "Dolar: " + value;
                dolar = decimal.Parse(value);
            }




            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "key" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text = "Euro: " + value2;
                euro = decimal.Parse(value2);
            }


            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
            {
                { "x-rapidapi-key", "key" },
                { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
            },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblPound.Text = "Pound: " + value3;
                sterlin = decimal.Parse(value3);
            }
            txtTotalPrice.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            decimal totalPrice = 0;

            if (rdbDolar.Checked)
            {
                totalPrice = unitPrice * dolar;
            }
            if (rdbEuro.Checked)
            {
                totalPrice = unitPrice * euro;
            }
            if (rdbPound.Checked)
            {
                totalPrice = unitPrice * sterlin;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
