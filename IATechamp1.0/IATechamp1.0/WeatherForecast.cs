<<<<<<<< HEAD:IATechamp1.0/IATechamp1.0/WeatherForecast.cs
namespace IATechamp1._0
========
namespace IATechamp1._0.Class
>>>>>>>> ProjectVersion2.0:IATechamp1.0/IATechamp1.0/Model/WeatherForecast.cs
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}