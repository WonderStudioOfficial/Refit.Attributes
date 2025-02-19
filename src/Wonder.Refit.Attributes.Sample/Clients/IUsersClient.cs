using Wonder.Refit.Attributes.Sample.ApiStores;

namespace Wonder.Refit.Attributes.Sample.Clients;

public interface IWeatherForecastsClient
{
    [WonderGet(ApiStore.WeatherForecasts.GetRandom)]
    Task<IEnumerable<WeatherForecast>> GetUser(int number);
}