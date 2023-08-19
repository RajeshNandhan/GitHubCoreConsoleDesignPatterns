namespace BehavioralPatterns.Command
{
    internal interface ICommandCanExecute
    {
        bool CanExecute(); // its an internal matter to ICommand
    }
}
