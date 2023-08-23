using System.Collections.Generic;

namespace BehavioralPatterns.Observer
{
    /// <summary>
    /// PUSH PULL MODEL
    /// </summary>
    internal class WeatherStationWeatherObservable : IWeatherObservable
    {
        private List<IWeatherObserver> weatherObservers;
        Weather weather;

        public WeatherStationWeatherObservable()
        {
            weatherObservers = new List<IWeatherObserver>();
        }

        public void AddObservers(IWeatherObserver weatherObserver)
        {
            weatherObservers.Add(weatherObserver);
        }

        public void RemoveObservers(IWeatherObserver weatherObserver)
        {
            weatherObservers.Remove(weatherObserver);
        }

        //FUNCTION PUSH THE NOTIFICATION
        public void NotifyWeatherChange()
        {
            foreach (var weatherObserver in weatherObservers)
            {
                weatherObserver.UpdateObserversWeatherChanges();
            }
        }

        //FUNCTION FOR PULL MESAGE 
        public Weather GetWeatherChanages()
        {
            return weather;
        }

        public void SetWeatherChanages(Weather weather)
        {
            this.weather = weather;
        }
    }
}
