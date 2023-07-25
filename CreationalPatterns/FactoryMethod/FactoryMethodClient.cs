﻿using System;

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
            bool canContinue;
            do
            {
                Console.WriteLine("Please enter I for IPod or L for Laptop, or M for Mobile\n");
                Console.WriteLine("Please enter any key except I, L, M, to exit\n\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                AbstractProductFactory productFactory = null;

                switch (userEnteredKey)
                {
                    case "i":
                        productFactory = new IPodFactory();
                        break;
                    case "l":
                        productFactory = new LaptopFactory();
                        break;
                    case "m":
                        productFactory = new MobileFactory();
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
