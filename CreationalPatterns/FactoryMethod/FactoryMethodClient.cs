using System;

namespace CreationalPatterns.FactoryMethod
{
    internal class FactoryMethodClient
    {
        /// <summary>
        /// BuyProduct - Client implementation
        /// user provides a choice of product
        /// based on user choice of product, particular product created using factory method
        /// </summary>
        public static void BuyProduct()
        {
            bool canContinue = true;
            do
            {
                Console.WriteLine("Please enter C for Computer or L for Laptop, or M for Mobile\n");
                Console.WriteLine("Please enter any key except C, L, M, to exit\n\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                AbstractProductCreator abstractProductCreator = null;

                switch (userEnteredKey)
                {
                    case "c":
                        abstractProductCreator = new ConcreteProductComputerCreator();
                        break;
                    case "l":
                        abstractProductCreator = new ConcreteProductLaptopCreator();
                        break;
                    case "m":
                        abstractProductCreator = new ConcreteProductMobileCreator();
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    AbstractProduct abstractProduct = abstractProductCreator.FactoryMethod_CreateProduct();

                    Console.WriteLine("\n" + abstractProduct.Monitor + " - selected ! \n");
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
