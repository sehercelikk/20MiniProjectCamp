using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume İşlemine Hoş Geliniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçiniz ###");
Console.WriteLine();
Console.WriteLine("1- Şehir Listesi");
Console.WriteLine("2- Şehir ve Hava Durumu Listesi");
Console.WriteLine("3- Yeni Şehir Ekle");
Console.WriteLine("4- Şehir Sil");
Console.WriteLine("5- Şehir Güncelle");
Console.WriteLine("6- ID'ye Göre Getir");
Console.WriteLine();


string number;

Console.Write("Tercihiniz:");
number = Console.ReadLine();

switch (number)
{
    case "1":
        string url = "https://localhost:44395/api/Weather";
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            JArray jArray = JArray.Parse(responseBody);
            foreach (var item in jArray)
            {
                string cityName = item["name"].ToString();
                Console.WriteLine("Şehir " + cityName);
            }
        }
        break;
    case "2":
        string url2 = "https://localhost:44395/api/Weather";
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url2);
            string responseBody = await response.Content.ReadAsStringAsync();
            JArray jArray2 = JArray.Parse(responseBody);
            foreach (var item in jArray2)
            {
                string cityName = item["name"].ToString();
                string cityTemp = item["temp"].ToString();
                Console.WriteLine("Şehir Bİlgileri: " + cityName + " " + cityTemp + " Derece");
            }
        }
        Console.WriteLine();
        break;
    case "3":
        string url3 = "https://localhost:44395/api/Weather";
        string name, country, detail;
        decimal temp;
        Console.Write("Şehir Adı:");
        name = Console.ReadLine();
        Console.Write("Sıcaklık: ");
        temp = decimal.Parse(Console.ReadLine());
        Console.Write("Detay:");
        detail = Console.ReadLine();
        Console.Write("Ülke: ");
        country = Console.ReadLine();
        var newWeatherCity = new
        {
            Name = name,
            Temp = temp,
            Details = detail,
            Country = country,
        };
        using (HttpClient client=new HttpClient())
        {
            string json=JsonConvert.SerializeObject(newWeatherCity);
            StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
            HttpResponseMessage response= await client.PostAsync(url3, content);
            response.EnsureSuccessStatusCode();
            Console.WriteLine("Ekleme işlemi başarılı");
        }
        break;
    case "4":
        string url4 = "https://localhost:44395/api/Weather?id=";
        Console.Write("Silmek istediğiniz ID:");
        int id=int.Parse(Console.ReadLine());
        using (HttpClient client=new HttpClient())
        {
            HttpResponseMessage response= await client.DeleteAsync(url4 + id);
            response.EnsureSuccessStatusCode();
            Console.WriteLine("Silme işlemi başarılı");

        }
        break;
    case "5":
        string url5 = "https://localhost:44395/api/Weather?id=";
        string guncelName, guncelCountry, guncelDetail;
        decimal guncelTemp;
        int guncellenecekId;

        Console.Write("Şehir ID:");
        guncellenecekId = int.Parse(Console.ReadLine());

        Console.Write("Şehir Adı:");
        guncelName = Console.ReadLine();

        Console.Write("Sıcaklık: ");
        guncelTemp = decimal.Parse(Console.ReadLine());

        Console.Write("Detay:");
        guncelDetail = Console.ReadLine();

        Console.Write("Ülke: ");
        guncelCountry = Console.ReadLine();

        var updatedWeatherValues = new
        {
            CityId = guncellenecekId,
            Name = guncelName,
            Temp = guncelTemp,
            Details = guncelDetail,
            Country = guncelCountry,
        };

        using(HttpClient client=new HttpClient())
        {
            string json = JsonConvert.SerializeObject(updatedWeatherValues);
            StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
            HttpResponseMessage response= await client.PutAsync(url5, content);
            response.EnsureSuccessStatusCode();
            Console.WriteLine("Güncelleme işlemi başarılı");

        }
        break;
    case "6":
        string url6 = "https://localhost:44395/api/Weather/GetByIdCity?id=";
        Console.Write("Bilgilerini Getirmek İstediğiniz ID yi gitin:");
        int getById=int.Parse(Console.ReadLine());
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response= await client.GetAsync(url6+getById);
            response.EnsureSuccessStatusCode();
            string responseBody=await response.Content.ReadAsStringAsync();
            JObject weatherCity = JObject.Parse(responseBody);
            string cityName = weatherCity["name"].ToString();
            string details = weatherCity["details"].ToString();
            decimal tempget = decimal.Parse(weatherCity["temp"].ToString());
            string countryget = weatherCity["country"].ToString();
            Console.WriteLine("İstediğiniz Şehir Bilgileri:");
            Console.Write("Şehir: "+cityName+ " Detay: "+ details + " Sıcaklık: "+ tempget+ " Ülke: "+ countryget);

        }
        break;
    default:
        Console.WriteLine("Geçersiz Seçim");
        break;
}

Console.Read();

