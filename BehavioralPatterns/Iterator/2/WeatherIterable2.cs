using System;

namespace BehavioralPatterns.Iterator
{
    internal class WeatherIterable2 : IWeatherIterable
    {
        public Weather[] Weathers;

        public int TotalIteratorCount
        {
            get;
            set;
        }

        public WeatherIterable2(int totalIteratorCount)
        {
            Random rand = new Random();

            TotalIteratorCount = totalIteratorCount;

            Weathers = new Weather[totalIteratorCount];

            for (int i = 0; i < TotalIteratorCount; i++)
            {
                var currentTemperature = rand.Next(10, 40);
                var weather = new Weather(currentTemperature);

                Weathers[i] = weather;
            }
        }

        public IWeatherIterator GetWeatherIterator()
        {
            return new WeatherIterator2(this);
        }
    }
}
