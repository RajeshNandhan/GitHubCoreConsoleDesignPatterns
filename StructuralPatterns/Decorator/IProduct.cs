namespace StructuralPatterns.Decorator
{
    /*
     * attached behaviour at run time
flexible alternative to sub classing
aggreigate
    */
    internal interface IProduct
    {
        string GetProductName();

        int GetProductCost();
    }
}
 