using System;

namespace BehavioralPatterns.Observer
{
    /// <summary>
    /// THIS IS NOT SO RELEVENT TO THE PATTERN
    /// </summary>
    internal class Weather
    {
        private int Temprature;
        private DateTime TimeNow;

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
