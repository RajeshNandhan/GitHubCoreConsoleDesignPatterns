using System;

namespace CreationalPatterns.FactoryMethod
{
    internal class FactoryMethodClient
    {
        public static void TestMethod()
        {
            bool canContinue;

            Console.WriteLine("Please enter 'B' for Balance Product Factory to Create a Product\n");
            Console.WriteLine("Please enter 'R' for Random Product Factory to Create a Product\n\n");

            do
            {
                Console.WriteLine("Please enter any key except B,R, to exit");

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                AbstractProductFactory productFactory = null;

                switch (userEnteredKey)
                {
                    case "r":
                        productFactory = new RandomProductFactory();
                        break;
                    case "b":
                        productFactory = new BalanceProductFactory();
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    AbstractProduct abstractProduct = productFactory.FactoryMethod_CreateProduct();

                    Console.WriteLine("\n " + abstractProduct.ToProductString() + " \n");
                }
            } while (canContinue);
        }
    }
}
