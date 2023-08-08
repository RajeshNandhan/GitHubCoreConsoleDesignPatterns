namespace BehavioralPatterns.Strategy
{
    internal class MouseInBuiltBehaviour : IMouseStrategy
    {
        public string GetMouseType()
        {
            return "Mouse Type = Touch Pad";
        }
    }
}
