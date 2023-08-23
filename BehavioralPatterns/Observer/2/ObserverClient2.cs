using BehavioralPatterns.Observer;
using System;

namespace BehavioralPatterns.Observer2
{
    internal class ObserverClient2
    {
        public static void WeatherTest()
        {
            bool canContinue;

            WeatherStation2WeatherObservable weatherStation = new WeatherStation2WeatherObservable();

            BBCNews2WeatherObserver bBCNews = new BBCNews2WeatherObserver();
            NDTVNews2WeatherObserver nDTVNews = new NDTVNews2WeatherObserver();
            MobileWeatherApp2WeatherObserver mobileWeatherApp = new MobileWeatherApp2WeatherObserver();

            weatherStation.AddObservers(bBCNews);
            weatherStation.AddObservers(nDTVNews);
            weatherStation.AddObservers(mobileWeatherApp);

            do
            {
                Random rand = new Random();
                var currentTemperature = rand.Next(20, 40);
                var weather = new Weather(currentTemperature);

                /******** Pattern Testing *********/




                weatherStation.SetWeatherChanages(weather);
                weatherStation.NotifyWeatherChange();



                /******** Pattern Testing *********/

                Console.WriteLine("Please enter 'y' to continue or enter any other key to exit\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = userEnteredKey == "y";

            } while (canContinue);
        }

        public static void TestMethod()
        {
            WeatherTest();
        }
    }
}
