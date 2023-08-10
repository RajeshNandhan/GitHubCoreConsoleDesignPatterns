using System;

namespace BehavioralPatterns.Observer
{
    internal class MobileWeatherApp : IWeatherObserver
    {
        private readonly WeatherStation weatherStation;
        private Weather weather;

        public MobileWeatherApp(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void UpdateObserversWeatherChanges()
        {
            //PULL THE WEATEHR UPDATE
            weather = weatherStation.GetWeatherChanages();


            string weatherUpdate = $"Mobile Weather App update - {weather.ToWeatherString()}";
            Console.WriteLine(weatherUpdate);
        }
    }
}
