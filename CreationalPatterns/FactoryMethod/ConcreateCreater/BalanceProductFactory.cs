namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// BalanceProductFactory creates objects IPod, Laptop, Mobile in a sequence on each request
    /// </summary>
    internal class BalanceProductFactory : AbstractProductFactory
    {
        private static int NextNumber = 0;
        public static int GetNextNumber()
        {
            if (NextNumber >= 3)
            {
                NextNumber = 1;
            }
            else
            {
                NextNumber++;
            }
            return NextNumber;
        }

        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            AbstractProduct abstractProduct = null;
            var num = GetNextNumber();

            switch (num)
            {
                case 1:
                    abstractProduct = new IPod("2 inch", "4");
                    break;
                case 2:
                    abstractProduct = new Laptop("15 inch", "104");
                    break;
                case 3:
                    abstractProduct = new Mobile("7 inch", "11");
                    break;
            }

            return abstractProduct;
        }
    }
}
