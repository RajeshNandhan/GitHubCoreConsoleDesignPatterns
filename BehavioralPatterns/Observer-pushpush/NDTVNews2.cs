using System;

namespace BehavioralPatterns.Observer2
{
    internal class NDTVNews2 : IWeatherObserver2
    {
        private Weather2 weather;

        public void UpdateObserversWeatherChanges(Weather2 weather)
        {
            this.weather = weather;
            string weatherUpdate = $"NDTV Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}