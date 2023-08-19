namespace StructuralPatterns.Bridge
{
    internal class BookProduct
    {
        public int GetBookCost()
        {
            return 350;
        }

        public string GetBookTitle()
        {
            return "The Alchemist";
        }

        public string GetCoverStory()
        {
            return "The Alchemist is a novel by Brazilian author Paulo Coelho which was first published in 1988";
        }

        public string GetTotalPages()
        {
            return "Number of pages - 160";
        }

        public string GetPublication()
        {
            return "Publication - Penguin Random House";
        }
    }
}
