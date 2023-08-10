using System;

namespace BehavioralPatterns.Observer2
{
    /// <summary>
    /// THIS IS NOT SO RELEVENT TO THE PATTERN
    /// </summary>
    internal class Weather2
    {
        private int Temprature;
        private DateTime TimeNow;

        public Weather2(int temprature)
        {
            Temprature = temprature;
            TimeNow = DateTime.Now;
        }

        public string ToWeatherString()
        {
            return $"Current Time = {TimeNow}, Current Temprature = {Temprature}\n";
        }
    }
}
