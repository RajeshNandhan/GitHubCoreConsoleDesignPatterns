using BehavioralPatterns.Strategy;

namespace BehavioralPatterns.Strategy
{
    internal class MouseExternalBehaviour : IMouseStrategy
    {
        public string GetMouseType()
        {
            return "Mouse Type = External Mouse with wire and wireless";
        }
    }
}