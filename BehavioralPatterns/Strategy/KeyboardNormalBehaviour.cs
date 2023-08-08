namespace BehavioralPatterns.Strategy
{
    internal class KeyboardNormalBehaviour : IKeyboardStrategy
    {
        public string GetNumberOfKeys()
        {
            return "Number of keys = 104";
        }
    }
}