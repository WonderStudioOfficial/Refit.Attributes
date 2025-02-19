# Wonder Studio
## _Refit Attributes_

We have added new attributes for the Refit library, which make it possible to write the path to the endpoint without a '/' at the beginning of the path. This is especially useful when you use constants to write paths and reuse them in both clients and controllers.

### Sample
```c#
public interface IWeatherForecastsClient
{
    [WonderGet(ApiStore.WeatherForecasts.GetRandom)]
    Task<IEnumerable<WeatherForecast>> GetUser(int number);
}
```
