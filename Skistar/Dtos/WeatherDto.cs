namespace Skistar.Dtos
{
    public record WeatherDto
    {
        public DateTime Date { get; init; }
        public double TemperatureC { get; set; }
        public string Summary { get; init; }
    }
}
