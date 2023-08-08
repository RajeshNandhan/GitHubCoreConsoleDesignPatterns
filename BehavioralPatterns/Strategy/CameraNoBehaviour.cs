namespace BehavioralPatterns.Strategy
{
    internal class CameraNoBehaviour : ICameraStrategy
    {
        public string GetCamera()
        {
            return "Camera Type = NO Camera";
        }
    }
}
