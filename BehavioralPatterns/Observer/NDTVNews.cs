using System;

namespace BehavioralPatterns.Observer
{
    internal class NDTVNews : IWeatherObserver
    {
        private readonly WeatherStation weatherStation;
        private Weather weather;

        public NDTVNews(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void UpdateObserversWeatherChanges()
        {
            weather = weatherStation.GetWeatherChanages();
            string weatherUpdate = $"NDTV Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}