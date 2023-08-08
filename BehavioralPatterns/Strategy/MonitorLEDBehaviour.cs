namespace BehavioralPatterns.Strategy
{
    internal class MonitorLEDBehaviour : IMonitorStrategy
    {
        public string GetMonitorType()
        {
            return "Monitor Type = LED Monitor";
        }
    }
}