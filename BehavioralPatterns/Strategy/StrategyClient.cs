using System;

namespace BehavioralPatterns.Strategy
{
    internal class StrategyClient
    {
        public static void BuyProduct()
        {
            bool canContinue;
            Console.WriteLine("Please enter I for IPod or L for Laptop, or M for Mobile or C for Computer\n");
            Console.WriteLine("Please enter any key except I, L, M, C to exit\n\n");

            do
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                Product product = null;

                switch (userEnteredKey)
                {
                    case "i":
                        product = new Product(
                            new MonitorLEDBehaviour(),
                            new MouseNoBehaviour(),
                            new KeyboardSpecialBehaviour(),
                            new CameraInBuiltBehaviour(),
                            new ProductTypeBehaviour("IPod")
                            );

                        break;

                    case "l":
                        product = new Product(
                           new MonitorLCDBehaviour(),
                           new MouseInBuiltBehaviour(),
                           new KeyboardNormalBehaviour(),
                           new CameraInBuiltBehaviour(),
                           new ProductTypeBehaviour("Laptop")
                           );

                        break;

                    case "m":
                        product = new Product(
                          new MonitorLEDBehaviour(),
                          new MouseNoBehaviour(),
                          new KeyboardSmallBehaviour(),
                          new CameraInBuiltBehaviour(),
                          new ProductTypeBehaviour("Mobile")
                          );
                        break;

                    case "c":
                        product = new Product(
                          new MonitorLCDBehaviour(),
                          new MouseExternalBehaviour(),
                          new KeyboardNormalBehaviour(),
                          new CameraNoBehaviour(),
                          new ProductTypeBehaviour("Computer")
                          );
                        break;

                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine(product.ToProductString());
                }
                else
                {
                    Console.WriteLine("\n thank you");
                }


            } while (canContinue);
        }

        public static void TestMethod()
        {
            BuyProduct();
        }
    }
}
