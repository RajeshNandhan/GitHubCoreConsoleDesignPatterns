namespace StructuralPatterns.Adapter
{
    internal class PigAnimalAdapter : Pig, IAnimalAdapter
    {
        public string Speak()
        {
            return this.Grunt();
        }

        public string Move()
        {
            return this.Walk();
        }
    }
}
