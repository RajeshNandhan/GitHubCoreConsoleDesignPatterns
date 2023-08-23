namespace BehavioralPatterns.Iterator
{
    /// <summary>
    /// IWeatherIterator or IWeatherEnumerator
    /// </summary>
    internal interface IWeatherIterator
    {
        bool IsIterationDone();

        void MoveToNextItem();

        Weather GetCurrentItem();
    }
}