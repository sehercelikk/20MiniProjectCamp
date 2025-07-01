using ApiWeather_Project6.Context;
using ApiWeather_Project6.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeather_Project6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        WeatherContext context= new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.Cities.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult WeatherCityAdd(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Şehir Eklendi");
        }

        [HttpDelete]
        public IActionResult WeatherCityDelete(int id)
        {
            var city = context.Cities.FirstOrDefault(a=>a.CityId==id);
            context.Cities.Remove(city);
            context.SaveChanges();
            return Ok("Silme işlemi başarılı");
        }

        [HttpPut]
        public IActionResult WeatherCityUpdate(City city)
        {
            var value=context.Cities.Find(city.CityId);
            value.Name= city.Name;
            value.Details= city.Details;
            value.Temp = city.Temp;
            value.Country= city.Country;
            context.SaveChanges();
            return Ok("Güncellendi");
        }

        [HttpGet("GetByIdCity")]
        public IActionResult GetByIdCity(int id)
        {
            var value = context.Cities.Find(id);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var value=context.Cities.Count();
            return Ok(value);
        }

        [HttpGet("MaxTempCityName")]
        public IActionResult MaxTempCityName()
        {
            var values= context.Cities.OrderByDescending(x=>x.Temp).Select(y=>y.Name).FirstOrDefault();
            return Ok(values);
        }
        [HttpGet("MinTempCityName")]
        public IActionResult MinTempCityName()
        {
            var values = context.Cities.OrderBy(x => x.Temp).Select(y => y.Name).FirstOrDefault();
            return Ok(values);
        }
    }
}
