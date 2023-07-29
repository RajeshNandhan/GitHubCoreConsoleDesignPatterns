namespace StructuralPatterns.Adapter
{
    internal class LionConcreteAnimalAdapter : IAnimalAdapter
    {
        /// <summary>
        /// Composition (create instance) of Duck class
        /// </summary>
        private readonly Lion lion;

        public LionConcreteAnimalAdapter(Lion lion)
        {
            this.lion = lion;
        }

        public string MakeNoise()
        {
            return lion.Roars();
        }

        public string Movement()
        {
            return lion.Pounce();
        }
        public string AnimalType()
        {
            return lion.AnimalType();
        }
    }
}
