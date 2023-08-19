using BehavioralPatterns.Observer;

namespace BehavioralPatterns.Observer2
{
    internal interface IWeatherObserver2
    {
        void UpdateObserversWeatherChanges(Weather weather);
    }
}
