namespace StructuralPatterns.Adapter
{
    /*
     * no additional behaviour
acihve interaprabability 

signatuture change
lagacy class to new model like external library, to get retire, indirection call for signature changes
    */

    internal class Pig
    {
        public string Grunt()
        {
            return "Oink Oink";
        }

        public string Walk()
        {
            return "Walk";
        }

        public string AnimalType()
        {
            return "Pig";
        }
    }
}
