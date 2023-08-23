using System;
using System.Threading;

namespace BehavioralPatterns.Iterator
{
    internal class WeatherIterator : IWeatherIterator
    {
        private readonly WeatherIterable weatherIterable;
        private int CurrentIteratorIndex = 0;
        readonly Random rand = new Random();

        public WeatherIterator(WeatherIterable weatherIterable)
        {
            this.weatherIterable = weatherIterable;
        }

        public Weather GetCurrentItem()
        {
            var currentTemperature = rand.Next(10, 40);
            var weather = new Weather(currentTemperature);
            return weather;
        }

        public bool IsIterationDone()
        {
            return CurrentIteratorIndex >= weatherIterable.TotalIteratorCount;
        }

        public void MoveToNextItem()
        {
            /* Thread.Sleep is only for TESTING PUPOSE */
            Random rand = new Random();
            Thread.Sleep(rand.Next(500, 2500));

            CurrentIteratorIndex++;
        }
    }
}
