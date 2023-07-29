namespace StructuralPatterns.Facade
{
    internal class Laptop
    {
        public int GetProductCost()
        {
            return 3500;
        }

        public string GetProductName()
        {
            return "Laptop";
        }

        public int GetMouseCost()
        {
            return 150;
        }

        public int GetDeviceCoverCost()
        {
            return 70;
        }
    }
}
