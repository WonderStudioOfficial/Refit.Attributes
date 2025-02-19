namespace Wonder.Refit.Attributes.Sample.ApiStores;

public static partial class ApiStore
{
    private const string Prefix = "api";

    public static class WeatherForecasts
    {
        public const string ModuleName = "weather-forecast";

        public const string RoutePath = $"/{Prefix}/{ModuleName}";

        public const string GetRandom = @$"five-random/{{number}}";
    }
}