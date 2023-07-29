namespace StructuralPatterns.Adapter
{
    internal class LionAnimalAdapter : IAnimalAdapter
    {
        /// <summary>
        /// Composition (create instance) of Duck class
        /// </summary>
        private readonly Lion lion;

        public LionAnimalAdapter(Lion lion)
        {
            this.lion = lion;
        }

        public string Speak()
        {
            return lion.Roars();
        }

        public string Move()
        {
            return lion.Pounce();
        }
        public string AnimalType()
        {
            return lion.AnimalType();
        }
    }
}
