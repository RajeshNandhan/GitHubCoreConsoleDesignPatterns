namespace BehavioralPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
