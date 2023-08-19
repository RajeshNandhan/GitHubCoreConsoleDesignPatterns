namespace StructuralPatterns.Bridge
{
    internal class ArtistProductAdapter : IProductAdapter
    {
        private readonly ArtistProduct artistProduct;

        public ArtistProductAdapter(ArtistProduct artistProduct)
        {
            this.artistProduct = artistProduct;
        }

        public string GetDescription()
        {
            return artistProduct.GetBiography();
        }

        public string GetMoreInformation()
        {
            return artistProduct.GetAward();
        }

        public string GetTitle()
        {
            return artistProduct.GetArtistName();
        }
    }
}
