using System;

namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// RandomProductFactory creates objects IPod, Laptop, Mobile in a random order on each request
    /// </summary>
    internal class RandomProductFactory : AbstractProductFactory
    {
        public static int GetRandomNumber()
        {
            Random rnd = new Random();
            var result = rnd.Next(1, 4);
            Console.WriteLine(result);
            return result;
        }

        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            AbstractProduct abstractProduct;

            switch (GetRandomNumber())
            {
                case 1:
                    abstractProduct = new IPod("2 inch", "4");
                    break;
                case 2:
                    abstractProduct = new Laptop("15 inch", "104");
                    break;
                default:
                    abstractProduct = new Mobile("7 inch", "11");
                    break;
            }

            return abstractProduct;
        }
    }
}
