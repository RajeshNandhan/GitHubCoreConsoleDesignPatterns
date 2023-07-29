namespace StructuralPatterns.Facade
{
    internal class IPod
    {
        public int GetProductCost()
        {
            return 900;
        }

        public string GetProductName()
        {
            return "IPod";
        }

        public int GetDeviceCoverCost()
        {
            return 70;
        }
    }
}
