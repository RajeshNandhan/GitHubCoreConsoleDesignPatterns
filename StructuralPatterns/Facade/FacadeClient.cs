using System;
/*
 * principle of least knowledge
talk only to your immediate friend
law of demiter

*/

namespace StructuralPatterns.Facade
{
    internal class FacadeClient
    {
        public static void DecoratorClientTest()
        {
            ProductPurchaseFacade productPurchaseFacade = new ProductPurchaseFacade();

            Console.WriteLine("Products - " + productPurchaseFacade.GetProducts() + "\n");
            Console.WriteLine("Product Cover Cost - " + productPurchaseFacade.GetProductCoverCost() + "\n");
            Console.WriteLine("Product Actual Cost - " + productPurchaseFacade.GetProductActualCost() + "\n");
            Console.WriteLine("Product KeyBoard Cost - " + productPurchaseFacade.GetProductKeyBoardCost() + "\n");
            Console.WriteLine("Product Mouse Cost - " + productPurchaseFacade.GetProductMouseCost() + "\n");
        }
        public static void TestMethod()
        {
            DecoratorClientTest();
            Console.ReadKey();
        }
    }
}
