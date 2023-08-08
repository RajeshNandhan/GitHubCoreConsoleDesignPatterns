namespace BehavioralPatterns.Strategy
{
    internal class CameraInBuiltBehaviour : ICameraStrategy
    {
        public string GetCamera()
        {
            return "Camera Type = In Built Camera";
        }
    }
}
