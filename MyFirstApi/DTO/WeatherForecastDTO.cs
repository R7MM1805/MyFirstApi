namespace MyFirstApi.DTO
{
    public class WeatherForecastDTO(DateOnly date, int temperatureC, string summary)
    {
        public DateOnly Date { get; set; } = date;
        public int TemperatureC { get; set; } = temperatureC;
        public int TemperatureF { get; set; } = 32 + (int)(temperatureC / 0.5556);
        public string Summary { get; set; } = summary;
    }
}