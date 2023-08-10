using System;

namespace BehavioralPatterns.Observer2
{
    internal class ObserverClient2
    {
        public static void WeatherTest()
        {
            bool canContinue;

            WeatherStation2 weatherStation = new WeatherStation2();

            BBCNews2 bBCNews = new BBCNews2();
            NDTVNews2 nDTVNews = new NDTVNews2();
            MobileWeatherApp2 mobileWeatherApp = new MobileWeatherApp2();

            weatherStation.AddObservers(bBCNews);
            weatherStation.AddObservers(nDTVNews);
            weatherStation.AddObservers(mobileWeatherApp);

            do
            {
                Random rand = new Random();
                var currentTemperature = rand.Next(20, 40);
                var weather = new Weather2(currentTemperature);

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
