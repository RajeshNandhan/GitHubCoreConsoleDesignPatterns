using System;

namespace BehavioralPatterns.Observer
{
    internal class BBCNews : IWeatherObserver, IDisplayMessage
    {
        private readonly WeatherStation weatherStation;
        private Weather weather;

        public BBCNews(WeatherStation weatherStation)
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
