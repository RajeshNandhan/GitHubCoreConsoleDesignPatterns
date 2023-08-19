using System;
namespace StructuralPatterns.Bridge
{
    internal class BookProductAdapter : IProductAdapter
    {
        private readonly BookProduct bookProduct;

        public BookProductAdapter(BookProduct bookProduct)
        {
            this.bookProduct = bookProduct;
        }

        public string GetDescription()
        {
            return bookProduct.GetCoverStory();
        }

        public string GetMoreInformation()
        {
            return bookProduct.GetTotalPages() + ", " + bookProduct.GetPublication();
        }

        public string GetTitle()
        {
            return bookProduct.GetBookTitle();
        }
    }
}
