using BehavioralPatterns.Observer;
using System;

namespace BehavioralPatterns.Observer2
{
    internal class MobileWeatherApp2WeatherObserver : IWeatherObserver2, IDisplayMessage
    {
        public void showMessage(Weather weather)
        {
            string weatherUpdate = $"Mobile Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }

        public void UpdateObserversWeatherChanges(Weather weather)
        {
            showMessage(weather);
        }
    }
}
