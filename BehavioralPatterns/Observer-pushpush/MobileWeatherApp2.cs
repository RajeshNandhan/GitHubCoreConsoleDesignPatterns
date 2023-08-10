using System;

namespace BehavioralPatterns.Observer2
{
    internal class MobileWeatherApp2 : IWeatherObserver2
    {
        private Weather2 weather;

        public void UpdateObserversWeatherChanges(Weather2 weather)
        {
            this.weather = weather;

            string weatherUpdate = $"Mobile Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}
