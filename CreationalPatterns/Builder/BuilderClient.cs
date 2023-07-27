using System;

namespace CreationalPatterns.Builder
{
    internal class BuilderClient
    {
        /// <summary>
        /// BuyProduct - Client implementation
        /// user provides a choice of product
        /// based on user choice of product, particular product created using Builder method
        /// </summary>
        public static void BuyProduct()
        {
            bool canContinue;
            do
            {
                Console.WriteLine("Please enter I for IPod or L for Laptop, or M for Mobile\n");
                Console.WriteLine("Please enter any key except I, L, M, to exit\n\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                AbstractProductBuilder productBuilder = null;

                switch (userEnteredKey)
                {
                    case "i":
                        productBuilder = new IPodBuilder();
                        break;
                    case "l":
                        productBuilder = new LaptopBuilder();
                        break;
                    case "m":
                        productBuilder = new MobileBuilder();
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    productBuilder
                        .SetProductName()
                        .SetMonitorSize()
                        .SetNumberOfKeys();

                    Product abstractProduct = productBuilder.BuildProduct();

                    Console.WriteLine("\n " + abstractProduct.ToProductString() + " \n");
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
