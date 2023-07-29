namespace StructuralPatterns.Adapter
{
    internal class DuckAnimalAdapter : IAnimalAdapter
    {
        /// <summary>
        /// Composition (create instance) of Duck class
        /// </summary>
        private readonly Duck duck;

        public DuckAnimalAdapter(Duck duck)
        {
            this.duck = duck;
        }

        public string Speak()
        {
            return duck.Quack();
        }

        public string Move()
        {
            return duck.Swim();
        }

        public string AnimalType()
        {
            return duck.AnimalType();
        }
    }
}
