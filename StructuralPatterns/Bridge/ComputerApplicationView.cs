using System;

namespace StructuralPatterns.Bridge
{
    internal class ComputerApplicationView : IView
    {
        public ComputerApplicationView(IProductAdapter productAdapter) : base(productAdapter)
        {
        }

        public override void DisplayProductData()
        {
            Console.WriteLine("\nProduct : " + productAdapter.GetTitle());

            Console.WriteLine(productAdapter.GetDescription());

            Console.WriteLine(productAdapter.GetMoreInformation());
        }
    }
}
