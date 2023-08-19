using BehavioralPatterns.Observer;
using System;

namespace BehavioralPatterns.Observer2
{
    internal class NDTVNews2 : IWeatherObserver2, IDisplayMessage
    {
        public void showMessage(Weather weather)
        {
            string weatherUpdate = $"NDTV Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }

        public void UpdateObserversWeatherChanges(Weather weather)
        {
            showMessage(weather);
        }
    }
}