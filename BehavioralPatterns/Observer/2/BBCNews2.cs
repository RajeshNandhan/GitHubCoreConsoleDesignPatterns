using BehavioralPatterns.Observer;
using System;

namespace BehavioralPatterns.Observer2
{
    internal class BBCNews2 : IWeatherObserver2, IDisplayMessage
    {
        public void showMessage(Weather weather)
        {
            string weatherUpdate = $"BBC Weather update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }

        //WEATHER DATA PUSHED FROM STATION 
        public void UpdateObserversWeatherChanges(Weather weather)
        {
            showMessage(weather);
        }
    }
}
