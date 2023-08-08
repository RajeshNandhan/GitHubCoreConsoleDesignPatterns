namespace BehavioralPatterns.Strategy
{
    internal class MouseNoBehaviour : IMouseStrategy
    {
        public string GetMouseType()
        {
            return "Mouse Type = NO";
        }
    }
}

