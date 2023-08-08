namespace BehavioralPatterns.Strategy
{
    internal class MonitorLCDBehaviour : IMonitorStrategy
    {
        public string GetMonitorType()
        {
            return "Monitor Type = LCD Monitor";
        }
    }
}
