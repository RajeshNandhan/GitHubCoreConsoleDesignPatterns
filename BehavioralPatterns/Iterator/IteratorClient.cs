using System;

namespace BehavioralPatterns.Iterator
{
    internal class IteratorClient
    {
        public static void WeatherTest_1()
        {
            Console.WriteLine("Please enter number of Iteration for weather to show.");
            string consoleKeyInfo = Console.ReadLine();
            int totalIteratorCount = int.Parse(consoleKeyInfo);

            if (totalIteratorCount > 0)
            {
                WeatherIterable weatherIterable = new WeatherIterable(totalIteratorCount);
                IWeatherIterator weatherIterator = weatherIterable.GetWeatherIterator();

                do
                {
                    Weather currentWeather = weatherIterator.GetCurrentItem();
                    Console.WriteLine(currentWeather.ToWeatherString());
                    weatherIterator.MoveToNextItem();

                } while (!weatherIterator.IsIterationDone());

            }

            Console.WriteLine("Please any key to exit\n");
            Console.ReadKey();
        }

        public static void WeatherTest_2()
        {
            Console.WriteLine("Please enter number of Iteration for weather to show.");
            string consoleKeyInfo = Console.ReadLine();
            int totalIteratorCount = int.Parse(consoleKeyInfo);

            if (totalIteratorCount > 0)
            {
                WeatherIterable2 weatherIterable = new WeatherIterable2(totalIteratorCount);
                IWeatherIterator weatherIterator = weatherIterable.GetWeatherIterator();

                do
                {
                    Weather currentWeather = weatherIterator.GetCurrentItem();
                    Console.WriteLine(currentWeather.ToWeatherString());
                    weatherIterator.MoveToNextItem();

                } while (!weatherIterator.IsIterationDone());

            }

            Console.WriteLine("Please any key to exit\n");
            Console.ReadKey();
        }

        public static void TestMethod()
        {
            WeatherTest_1();
            //WeatherTest_2();
        }
    }
}