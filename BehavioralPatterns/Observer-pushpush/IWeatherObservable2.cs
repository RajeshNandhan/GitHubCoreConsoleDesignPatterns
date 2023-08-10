namespace BehavioralPatterns.Observer2
{
    /// <summary>
    /// IWeatherObservable or IWeatherSubject
    /// </summary>
    internal interface IWeatherObservable2
    {
        void AddObservers(IWeatherObserver2 weatherObserver);

        void RemoveObservers(IWeatherObserver2 weatherObserver);

        void NotifyWeatherChange();
    }
}