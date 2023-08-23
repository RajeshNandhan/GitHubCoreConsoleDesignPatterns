using System;
using System.Threading;

namespace BehavioralPatterns.Iterator
{
    internal class WeatherIterator2 : IWeatherIterator
    {
        private readonly WeatherIterable2 weatherIterable2;
        private int CurrentIteratorIndex = 0;

        public  WeatherIterator2(WeatherIterable2 weatherIterable2)
        {
            this.weatherIterable2 = weatherIterable2;
        }

        public Weather GetCurrentItem()
        {
            return this.weatherIterable2.Weathers[CurrentIteratorIndex];
        }

        public bool IsIterationDone()
        {
            return CurrentIteratorIndex >= weatherIterable2.TotalIteratorCount;
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
