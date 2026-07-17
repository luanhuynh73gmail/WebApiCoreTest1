namespace WebapiCoreTest1
{
    public class WeatherForecast
    {
        //this is from main
        //branch1 test1
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
