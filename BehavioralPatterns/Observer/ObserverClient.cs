using System;

namespace BehavioralPatterns.Observer
{
    internal class ObserverClient
    {
        public static void WeatherTest()
        {
            bool canContinue;

            WeatherStation weatherStation = new WeatherStation();

            BBCNews bBCNews = new BBCNews(weatherStation);
            NDTVNews nDTVNews = new NDTVNews(weatherStation);
            MobileWeatherApp mobileWeatherApp = new MobileWeatherApp(weatherStation);

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
