using System;

namespace StructuralPatterns.Adapter
{
    internal class Lion
    {
        public string Roars()
        {
            return "Gharr Gharr";
        }

        public string Pounce()
        {
            return "Pounce";
        }

        public string AnimalType()
        {
            return "Lion";
        }
    }
}
