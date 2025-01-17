namespace Weather.Models
{
    public class WeatherData
    {
        public string LocationName { get; set; } // 地點名稱
        public List<string> Day { get; set; } // 日期列表
        public List<double> AvgTemperature { get; set; } // 平均溫度列表
        public List<double> MaxTemperature { get; set; } // 最高溫度列表
        public List<double> MinTemperature { get; set; } // 最低溫度列表
    }
}
