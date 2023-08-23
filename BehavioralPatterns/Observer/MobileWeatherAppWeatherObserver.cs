using System;

namespace BehavioralPatterns.Observer
{
    internal class MobileWeatherAppWeatherObserver : IWeatherObserver, IDisplayMessage
    {
        private readonly WeatherStationWeatherObservable weatherStation;
        private Weather weather;

        public MobileWeatherAppWeatherObserver(WeatherStationWeatherObservable weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void UpdateObserversWeatherChanges()
        {
            //PULL THE WEATEHR UPDATE
            weather = weatherStation.GetWeatherChanages();
            showMessage(weather);
        }

        public void showMessage(Weather weather)
        {
            string weatherUpdate = $"Mobile Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}
