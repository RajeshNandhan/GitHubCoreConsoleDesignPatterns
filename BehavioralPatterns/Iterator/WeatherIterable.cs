namespace BehavioralPatterns.Iterator
{
    internal class WeatherIterable : IWeatherIterable
    {
        public int TotalIteratorCount
        {
            get;
            set;
        }

        public WeatherIterable(int totalIteratorCount)
        {
            TotalIteratorCount = totalIteratorCount;
        }

        public IWeatherIterator GetWeatherIterator()
        {
            return new WeatherIterator(this);
        }
    }
}
