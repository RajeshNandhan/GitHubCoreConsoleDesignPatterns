using System;

namespace StructuralPatterns.Bridge
{
    internal class BridgeClient
    {
        public static void BridgeClientTest()
        {
            bool canContinue;
            do
            {
                Console.WriteLine("\nPlease enter L - Laptop or B - Book, or A - Artist");
                ConsoleKeyInfo consoleKeyInfo1 = Console.ReadKey();
                string userEnteredKey1 = consoleKeyInfo1.Key.ToString().ToLower();

                Console.WriteLine("\nPlease enter M - Mobile View or C - Computer View, or Press Any other key to exit.");
                ConsoleKeyInfo consoleKeyInfo2 = Console.ReadKey();
                string userEnteredKey2 = consoleKeyInfo2.Key.ToString().ToLower();

                canContinue = true;

                IProductAdapter productAdapter = null;
                IView view = null;

                switch (userEnteredKey1)
                {
                    case "b":
                        productAdapter = new BookProductAdapter(new BookProduct());
                        break;
                    case "l":
                        productAdapter = new LaptopProductAdapter(new LaptopProduct());
                        break;
                    case "a":
                        productAdapter = new ArtistProductAdapter(new ArtistProduct());
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    if (userEnteredKey2 == "c")
                    {
                        view = new ComputerApplicationView(productAdapter);
                    }
                    else
                    {
                        view = new MobileApplicationView(productAdapter);
                    }

                    view.DisplayProductData();
                }
                else
                {
                    Console.WriteLine("\n thank you");
                }


            } while (canContinue);
        }

        public static void TestMethod()
        {
            BridgeClientTest();
        }
    }
}
