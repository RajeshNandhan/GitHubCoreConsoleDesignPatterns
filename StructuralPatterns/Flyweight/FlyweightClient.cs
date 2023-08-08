using System;

namespace StructuralPatterns.Flyweight
{
    internal class FlyweightClient
    {
        public static void CreateLaptop()
        {
            LaptopFactory laptopFactory = new LaptopFactory();
            bool canContinue;

            Console.WriteLine("Please enter H for HP Laptop BIG ----- HH for HP Laptop SMALL.\n");
            Console.WriteLine("Please enter L for Lenovo Laptop BIG ----- LL for Lenovo Laptop SMALL.\n");
            Console.WriteLine("Please enter A for Apple Laptop BIG  ----- AA for Apple Laptop SMALL.\n");
            Console.WriteLine("Please enter any key except H, L, A, to exit\n");

            do
            {
                string consoleKeyInfo = Console.ReadLine();
                string userEnteredKey = consoleKeyInfo.ToLower();
                canContinue = true;

                LaptopFlyweight laptopFlyweight = null;

                switch (userEnteredKey)
                {
                    case "h":
                        laptopFlyweight = laptopFactory.GetLaptop("HP");
                        laptopFlyweight.SetExtrinsicStateVariables("14 inch", "8GB");

                        break;

                    case "l":
                        laptopFlyweight = laptopFactory.GetLaptop("Lenovo");
                        laptopFlyweight.SetExtrinsicStateVariables("15 inch", "8GB");

                        break;

                    case "a":
                        laptopFlyweight = laptopFactory.GetLaptop("Apple");
                        laptopFlyweight.SetExtrinsicStateVariables("14.5 inch", "16GB");

                        break;

                    case "hh":
                        laptopFlyweight = laptopFactory.GetLaptop("HP");
                        laptopFlyweight.SetExtrinsicStateVariables("24 inch", "32GB");

                        break;

                    case "ll":
                        laptopFlyweight = laptopFactory.GetLaptop("Lenovo");
                        laptopFlyweight.SetExtrinsicStateVariables("22 inch", "16GB");

                        break;

                    case "aa":
                        laptopFlyweight = laptopFactory.GetLaptop("Apple");
                        laptopFlyweight.SetExtrinsicStateVariables("20 inch", "64GB");

                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine("\n " + laptopFlyweight.ToProductString());
                }
                else
                {
                    Console.WriteLine("\n thank you");
                }

            } while (canContinue);
        }

        public static void TestMethod()
        {
            CreateLaptop();
        }
    }
}
