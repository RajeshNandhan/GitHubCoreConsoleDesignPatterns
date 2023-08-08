namespace BehavioralPatterns.Strategy
{
    internal class KeyboardSmallBehaviour : IKeyboardStrategy
    {
        public string GetNumberOfKeys()
        {
            return "Number of keys = 14";
        }
    }
}