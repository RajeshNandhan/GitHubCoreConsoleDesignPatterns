using System;

namespace BehavioralPatterns.Observer
{
    internal class BBCNewsWeatherObserver : IWeatherObserver, IDisplayMessage
    {
        private readonly WeatherStationWeatherObservable weatherStation;
        private Weather weather;

        public BBCNewsWeatherObserver(WeatherStationWeatherObservable weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void showMessage(Weather weather)
        {
            string weatherUpdate = $"BBC Weather update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }

        public void UpdateObserversWeatherChanges()
        {
            weather = weatherStation.GetWeatherChanages();
            showMessage(weather);
        }
    }
}
