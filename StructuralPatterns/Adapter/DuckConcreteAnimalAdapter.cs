namespace StructuralPatterns.Adapter
{
    internal class DuckConcreteAnimalAdapter : IAnimalAdapter
    {
        /// <summary>
        /// Composition (create instance) of Duck class
        /// </summary>
        private readonly Duck duck;

        public DuckConcreteAnimalAdapter(Duck duck)
        {
            this.duck = duck;
        }

        public string MakeNoise()
        {
            return duck.Quack();
        }

        public string Movement()
        {
            return duck.Swim();
        }

        public string AnimalType()
        {
            return duck.AnimalType();
        }
    }
}
