using System.Collections.Generic;
using System.Threading;

namespace StructuralPatterns.Flyweight
{
    internal class LaptopFactory
    {
        private readonly IDictionary<string, LaptopFlyweight> laptops = new Dictionary<string, LaptopFlyweight>();

        public LaptopFlyweight GetLaptop(string type)
        {
            if (laptops.ContainsKey(type))
                return laptops[type];

            var laptop = CreateLaptop(type);
            laptops.Add(type, laptop);

            return laptop;
        }

        private LaptopFlyweight CreateLaptop(string type)
        {
            Thread.Sleep(1000);

            LaptopFlyweight laptopAbstract;

            switch (type)
            {
                case "Apple":
                    laptopAbstract = new AppleLaptopConcreteFlyweight("Apple", "Mac OS Big Sur", "Apple M1 Chip");
                    break;

                case "Lenovo":
                    laptopAbstract = new AppleLaptopConcreteFlyweight("Lenovo", "Windows 11", "Intel® Core");
                    break;

                case "HP":
                    laptopAbstract = new AppleLaptopConcreteFlyweight("HP", "Linux", "AMD Ryzen");
                    break;

                default:
                    laptopAbstract = null;
                    break;
            };

            return laptopAbstract;
        }
    }
}
