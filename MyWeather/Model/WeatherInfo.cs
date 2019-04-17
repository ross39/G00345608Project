using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyWeather.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; } = 0;

        [JsonProperty("lat")]
        public double Latitude { get; set; } = 0;
    }

    public class CountryInfo
    {

        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty;
    }

    public class WeatherInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; } = 0;

        [JsonProperty("main")]
        public string Main { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("icon")]
        public string Icon { get; set; } = string.Empty;
    }

    public class MainWeatherForecast
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; } = 0;
        [JsonProperty("pressure")]
        public double Pressure { get; set; } = 0;

        [JsonProperty("humidity")]
        public double Humidity { get; set; } = 0;
        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; } = 0;

        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; } = 0;
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; } = 0;

        [JsonProperty("deg")]
        public double WindDirectionDegrees { get; set; } = 0;

    }

    public class Clouds
    {

        [JsonProperty("all")]
        public int CloudinessPercent { get; set; } = 0;
    }

    public class WeatherMain
    {
        //calls the other methods to retrive the data
        [JsonProperty("coord")]
        public Coord Coordinates { get; set; } = new Coord();

        [JsonProperty("sys")]
        public CountryInfo System { get; set; } = new CountryInfo();

        [JsonProperty("weather")]
        public List<WeatherInfo> Weather { get; set; } = new List<WeatherInfo>();

        [JsonProperty("main")]
        public MainWeatherForecast MainWeather { get; set; } = new MainWeatherForecast();

        [JsonProperty("wind")]
        public Wind Wind { get; set; } = new Wind();

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; } = new Clouds();

        [JsonProperty("id")]
        public int CityId { get; set; } = 0;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("dt_txt")]
        public string Date { get; set; } = string.Empty;

        [JsonIgnore]
        public string DisplayDate => DateTime.Parse(Date).ToLocalTime().ToString("g");
        [JsonIgnore]
        public string DisplayTemp => $"Temp: {MainWeather?.Temperature ?? 0}° {Weather?[0]?.Main ?? string.Empty}";
        [JsonIgnore]
        public string DisplayIcon => $"http://openweathermap.org/img/w/{Weather?[0]?.Icon}.png";
    }

    public class WeatherForecastRoot
    {
        [JsonProperty("city")]
        public CityInfo City { get; set; }
        [JsonProperty("cod")]
        public string Vod { get; set; }
        [JsonProperty("message")]
        public double Message { get; set; }
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        [JsonProperty("list")]
        public List<WeatherMain> Items { get; set; }

    }

    public class CityInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("coord")]
        public Coord Coord { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("population")]
        public int Population { get; set; }
        [JsonProperty("sys")]
        public CountryInfo Sys { get; set; }
    }

}
