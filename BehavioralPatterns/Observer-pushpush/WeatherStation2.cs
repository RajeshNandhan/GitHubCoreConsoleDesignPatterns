﻿using System.Collections.Generic;

namespace BehavioralPatterns.Observer2
{
    /// <summary>
    /// PUSH PULL MODEL
    /// </summary>
    internal class WeatherStation2 : IWeatherObservable2
    {
        private List<IWeatherObserver2> weatherObservers;
        Weather2 weather;

        public WeatherStation2()
        {
            weatherObservers = new List<IWeatherObserver2>();
        }

        public void AddObservers(IWeatherObserver2 weatherObserver)
        {
            weatherObservers.Add(weatherObserver);
        }

        public void RemoveObservers(IWeatherObserver2 weatherObserver)
        {
            weatherObservers.Remove(weatherObserver);
        }

        //FUNCTION PUSH THE NOTIFICATION
        public void NotifyWeatherChange()
        {
            foreach (var weatherObserver in weatherObservers)
            {
                weatherObserver.UpdateObserversWeatherChanges(weather);
            }
        }

        public void SetWeatherChanages(Weather2 weather)
        {
            this.weather = weather;
        }
    }
}
