namespace BehavioralPatterns.State
{
    internal interface IGate
    {
        void Enter();

        void PayProcess();

        void PaySuccess();

        void PayFail();

        void ChangeGateState(IGateState gateState);
    }
}
