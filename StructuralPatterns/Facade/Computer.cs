namespace StructuralPatterns.Facade
{
    internal class Computer
    {
        public int GetProductCost()
        {
            return 2000;
        }

        public string GetProductName()
        {
            return "Computer";
        }

        public int GetDeviceCoverCost()
        {
            return 70;
        }

        public int GetKeyBoardCost()
        {
            return 250;
        }

        public int GetMouseCost()
        {
            return 150;
        }
    }
}
