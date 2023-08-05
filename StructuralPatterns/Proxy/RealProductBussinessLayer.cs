using System;

namespace StructuralPatterns.Proxy
{
    /*
     * 

indirection in calling for security
solves or provides soln acccess contrl
remote proxy, virtaul proxy, protection proxy
adds  behaviour to control purposre not adding it for additional additional like decorater, no chnneg in interface
    */

    internal class RealProductBussinessLayer : IProductBussinessLayer
    {
        private Product laptop { get; set; }
        //
        public RealProductBussinessLayer(string monitorSize, string numberOfKeys, string productName)
        {
            laptop = new Product(monitorSize, numberOfKeys, productName);
        }

        public string GetMonitorSize()
        {
            return $"Monitor Size - {laptop.MonitorSize}, ";
        }

        public string GetNumberOfKeys()
        {
            return $"Number Of Keys -{laptop.NumberOfKeys}, ";
        }

        public string GetProductName()
        {
            return $"Product Name - {laptop.ProductName}, ";
        }
    }
}
