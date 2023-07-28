using System;

namespace CreationalPatterns.Singleton
{
    internal class SingletonClient
    {
        /// <summary>
        /// BuyProduct - Client implementation
        /// user provides a choice of product
        /// based on user choice of product, particular product created using factory method
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

                ProductCreaterSingleton productCreaterSingleton = ProductCreaterSingleton.CreateandGetSingleInstanceOfProductCreaterSingletonObject();
                AbstractProduct product = null;

                switch (userEnteredKey)
                {
                    case "i":
                        product = productCreaterSingleton.IPod;
                        break;
                    case "l":
                        product = productCreaterSingleton.Laptop;
                        break;
                    case "m":
                        product = productCreaterSingleton.Mobile;
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine("\n " + product.ToProductString() + " \n");
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
