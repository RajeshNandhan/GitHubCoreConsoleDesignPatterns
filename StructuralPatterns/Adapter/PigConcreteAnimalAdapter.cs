namespace StructuralPatterns.Adapter
{
    internal class PigConcreteAnimalAdapter : Pig, IAnimalAdapter
    {
        public string MakeNoise()
        {
            return this.Grunt();
        }

        public string Movement()
        {
            return this.Walk();
        }
    }
}
