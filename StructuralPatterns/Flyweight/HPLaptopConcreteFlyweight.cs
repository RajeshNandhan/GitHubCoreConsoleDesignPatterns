namespace StructuralPatterns.Flyweight
{
    internal class HPLaptopConcreteFlyweight : LaptopFlyweight
    {
        public HPLaptopConcreteFlyweight(string brandName, string operatingSystem, string processor) :
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
