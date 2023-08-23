using System;

namespace BehavioralPatterns.Observer
{
    internal class NDTVNewsWeatherObserver : IWeatherObserver, IDisplayMessage
    {
        private readonly WeatherStationWeatherObservable weatherStation;
        private Weather weather;

        public NDTVNewsWeatherObserver(WeatherStationWeatherObservable weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void UpdateObserversWeatherChanges()
        {
            weather = weatherStation.GetWeatherChanages();
            showMessage(weather);
        }

        public void showMessage(Weather weather)
        {
            string weatherUpdate = $"NDTV Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}