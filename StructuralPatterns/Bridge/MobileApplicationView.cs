using System;

namespace StructuralPatterns.Bridge
{
    internal class MobileApplicationView : IView
    {
        public MobileApplicationView(IProductAdapter productAdapter) : base(productAdapter)
        {
        }

        public override void DisplayProductData()
        {
            Console.WriteLine("\nProduct : " + productAdapter.GetTitle());

            Console.WriteLine(productAdapter.GetDescription());
        }
    }
}
