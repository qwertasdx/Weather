using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Weather.Models;
using Weather.ViewModel;

namespace Weather.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _httpClient;

        public WeatherController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            var cityViewModel = new CityViewModel();
            return View(cityViewModel); 
        }

        public async Task<IActionResult> WeatherAjaxJSON(string citySelect)
        {
            if (!string.IsNullOrEmpty(citySelect))
            {
                var response = await _httpClient.GetStringAsync($"http://localhost:5000/WeatherForecast/{citySelect}");
                var weatherDataList = JsonSerializer.Deserialize<List<WeatherData>>(response); // 反序列化

                // AJAX 請求，返回 JSON 格式
                return Json(weatherDataList);
            }

            return View(); 
        }
    }
}
