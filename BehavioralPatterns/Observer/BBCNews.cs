using System;

namespace BehavioralPatterns.Observer
{
    internal class BBCNews : IWeatherObserver
    {
        private readonly WeatherStation weatherStation;
        private Weather weather;

        public BBCNews(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void UpdateObserversWeatherChanges()
        {
            weather = weatherStation.GetWeatherChanages();
            string weatherUpdate = $"BBC Weather update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}
