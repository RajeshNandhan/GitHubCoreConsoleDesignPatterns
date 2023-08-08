namespace StructuralPatterns.Flyweight
{
    internal class LenovoLaptopConcreteFlyweight : LaptopFlyweight
    {
        public LenovoLaptopConcreteFlyweight(string brandName, string operatingSystem, string processor) :
            base(brandName, operatingSystem, processor)
        {
        }

        public override void SetExtrinsicStateVariables(string monitorSize, string memory)
        {
            this.MonitorSize = monitorSize;
            this.Memory = memory;
        }
    }
}
