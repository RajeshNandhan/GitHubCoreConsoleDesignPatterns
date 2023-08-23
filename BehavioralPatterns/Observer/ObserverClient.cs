using System;

namespace BehavioralPatterns.Observer
{
    internal class ObserverClient
    {
        public static void WeatherTest()
        {
            bool canContinue;

            WeatherStationWeatherObservable weatherStation = new WeatherStationWeatherObservable();

            BBCNewsWeatherObserver bBCNews = new BBCNewsWeatherObserver(weatherStation);
            NDTVNewsWeatherObserver nDTVNews = new NDTVNewsWeatherObserver(weatherStation);
            MobileWeatherAppWeatherObserver mobileWeatherApp = new MobileWeatherAppWeatherObserver(weatherStation);

            weatherStation.AddObservers(bBCNews);
            weatherStation.AddObservers(nDTVNews);
            weatherStation.AddObservers(mobileWeatherApp);

            do
            {
                Random rand = new Random();
                var currentTemperature = rand.Next(0, 40);
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
