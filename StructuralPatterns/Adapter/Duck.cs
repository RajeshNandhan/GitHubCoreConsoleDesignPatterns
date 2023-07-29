using System;

namespace StructuralPatterns.Adapter
{
    internal class Duck
    {
        public string Quack()
        {
            return "Quack Quack";
        }

        public string Swim()
        {
            return "Swim";
        }

        public string AnimalType()
        {
            return "Duck";
        }
    }
}

