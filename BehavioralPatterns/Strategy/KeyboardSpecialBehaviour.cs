namespace BehavioralPatterns.Strategy
{
    internal class KeyboardSpecialBehaviour : IKeyboardStrategy
    {
        public string GetNumberOfKeys()
        {
            return "Number of keys = 5";
        }
    }
}
