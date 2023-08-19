using System;

namespace BehavioralPatterns.Observer2
{
    internal class BBCNews2 : IWeatherObserver2
    {
        private Weather2 weather;

        //WEATHER DATA PUSHED FROM STATION 
        public void UpdateObserversWeatherChanges(Weather2 weather)
        {
            this.weather = weather;
            string weatherUpdate = $"BBC Weather update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}
