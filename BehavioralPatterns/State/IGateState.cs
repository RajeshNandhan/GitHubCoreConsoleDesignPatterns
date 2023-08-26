namespace BehavioralPatterns.State
{
    internal interface IGateState
    {
        void Enter(IGate gate);

        void PayProcess(IGate gate);

        void PaySuccess(IGate gate);

        void PayFail(IGate gate);
    }
}
