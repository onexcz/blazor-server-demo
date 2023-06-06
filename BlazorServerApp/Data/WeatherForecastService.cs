namespace BlazorServerApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {



            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }


        public string GetAdvice(string _focusedInputType)
        {
            return _focusedInputType switch
            {
                "DemoTextInput" => "Just type something in the box.",
                "DemoCheckboxInput" => "Check for TRUE uncheck for FALSE.",
                "DemoDateInput" => "Choose the date you find most exciting.",
                _ => "This form contains just demo inputs. It doesn't really do anything on submit :]",
            };
        }
    }
}