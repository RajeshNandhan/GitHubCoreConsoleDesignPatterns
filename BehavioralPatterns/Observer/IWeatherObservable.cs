namespace BehavioralPatterns.Observer
{
    /// <summary>
    /// IWeatherObservable or IWeatherSubject
    /// </summary>
    internal interface IWeatherObservable
    {
        void AddObservers(IWeatherObserver weatherObserver);

        void RemoveObservers(IWeatherObserver weatherObserver);

        void NotifyWeatherChange();
    }
}