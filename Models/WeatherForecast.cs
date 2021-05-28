using System;

namespace martinwestwood.Models
{
    public class WeatherForecast: IEquatable<WeatherForecast> 
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public bool Equals(WeatherForecast other)
        {
            if (other == null)
                return false;

            if ((this.Date == other.Date)
                && (this.TemperatureC == other.TemperatureC)
                && (this.Summary == other.Summary)
                )
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"The weather forecast for {Date} is {Summary}";
        }
    }
}
