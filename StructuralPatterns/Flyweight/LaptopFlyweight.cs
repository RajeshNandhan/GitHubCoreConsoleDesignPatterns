namespace StructuralPatterns.Flyweight
{
    internal abstract class LaptopFlyweight
    {
        public LaptopFlyweight(string brandName, string operatingSystem, string processor)
        {
            BrandName = brandName;
            OperatingSystem = operatingSystem;
            Processor = processor;
        }
        /* 1. Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.
        2. intrinsic vaiables for this laptop are BrandName, MonitorSize, NumberOfKeys*/

        public string BrandName
        {
            get;
        }

        public string OperatingSystem
        {
            get;
        }

        public string Processor
        {
            get;
        }

        /* 1. Any state that client computes or stores are the extrinsic state of flyweight, that is, it must be dependent of client object's context.
        2. Extrinsic state vaiables for this laptop are OperatingSystem, MotherBoard, RandomAcccessMemory*/
        public string MonitorSize
        {
            get;
            set;
        }

        public string Memory
        {
            get;
            set;
        }

        /// <summary>
        /// This methods basically created to get Extrinsic State Variables For Flyweight pattern
        /// </summary>
        /// <param name="monitorSize"></param>
        /// <param name="memory"></param>
        public abstract void SetExtrinsicStateVariables(string monitorSize, string memory);

        /// <summary>
        /// THIS METHOD NOT RELATED TO Flyweight PATTERN
        /// </summary>
        /// <returns></returns>
        public string ToProductString()
        {
            return $"Intrinsic State Variables (don't change) => Brand Name - {BrandName}, Operating System - {OperatingSystem}, Processor -{Processor} \n" +
               $"Extrinsic State Variables (need change on each instance possibly)  => Monitor Size - {MonitorSize}, RAM Memory - {Memory} \n";
        }
    }
}
