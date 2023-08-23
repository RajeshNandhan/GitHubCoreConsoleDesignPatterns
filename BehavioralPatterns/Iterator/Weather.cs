using System;

namespace BehavioralPatterns.Iterator
{
    /// <summary>
    /// THIS IS NOT SO RELEVENT TO THE PATTERN
    /// </summary>
    internal class Weather
    {
        public int Temprature
        {
            get;
            private set;
        }

        public DateTime TimeNow
        {
            get;
            private set;
        }

        public Weather(int temprature)
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