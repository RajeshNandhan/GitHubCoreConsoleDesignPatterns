using System;

namespace StructuralPatterns.Decorator
{
    internal class DecoratorClient
    {
        public static void DecoratorClientTest()
        {
            bool canContinue;
            do
            {
                Console.WriteLine("Please enter C for Computer or L for Laptop, or M for Mobile\n");
                Console.WriteLine("Please enter any key except C, L, M, to exit\n\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                IProduct product = null;

                switch (userEnteredKey)
                {
                    case "c":
                        product = DecorateComputerProduct();
                        break;
                    case "l":
                        product = DecorateLaptopProduct();
                        break;
                    case "m":
                        product = DecorateMobileProduct();
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine("\n " + "Accessory and Product - " + product.GetProductName() + "\n Total Price - " + product.GetProductCost() + " \n");
                }
                else
                {
                    Console.WriteLine("\n thank you");
                }


            } while (canContinue);
        }

        private static IProduct DecorateComputerProduct()
        {
            IProduct computerProduct = new ComputerProduct();

            var computerProductKeyBoardDecorated = new KeyboardAccessoryProductDecorator(computerProduct);

            var computerProductMouseDecorated = new MouseAccessoryProductDecorator(computerProductKeyBoardDecorated);

            var computerProductDeviceCoverDecorated = new DeviceCoverAccessoryProductDecorator(computerProductMouseDecorated);

            return computerProductDeviceCoverDecorated;
        }

        private static IProduct DecorateLaptopProduct()
        {
            IProduct computerProduct = new LaptopProduct();

            //NOT Required
            //var computerProductKeyBoardDecorated = new KeyboardAccessoryProductDecorator(computerProduct);

            var computerProductMouseDecorated = new MouseAccessoryProductDecorator(computerProduct);

            var computerProductDeviceCoverDecorated = new DeviceCoverAccessoryProductDecorator(computerProductMouseDecorated);

            return computerProductDeviceCoverDecorated;
        }

        private static IProduct DecorateMobileProduct()
        {
            IProduct computerProduct = new MobileProduct();

            //NOT Required
            //var computerProductKeyBoardDecorated = new KeyboardAccessoryProductDecorator(computerProduct);

            //var computerProductMouseDecorated = new MouseAccessoryProductDecorator(computerProductKeyBoardDecorated);

            var computerProductDeviceCoverDecorated = new DeviceCoverAccessoryProductDecorator(computerProduct);

            return computerProductDeviceCoverDecorated;
        }


        public static void TestMethod()
        {
            DecoratorClientTest();
        }
    }
}
