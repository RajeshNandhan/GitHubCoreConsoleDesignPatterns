namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// AbstractProductCreator
    /// </summary>
    internal abstract class AbstractProductFactory
    {
        /// <summary>
        /// This Method will create a product based on the "Creater" 
        /// </summary>
        /// <returns>This Method will return a concrete "Product" based on the "Creater" </returns>
        public abstract AbstractProduct FactoryMethod_CreateProduct();
    }
}
