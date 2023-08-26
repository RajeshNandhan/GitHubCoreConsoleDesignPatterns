namespace BehavioralPatterns.State
{
    internal class MetroGate : IGate
    {
        private IGateState gateState;

        public MetroGate()
        {
            //DEFAULT GATE STATE
            gateState = new CloseGateState();
        }

        public void Enter()
        {
            gateState.Enter(this);
        }

        public void PayFail()
        {
            gateState.PayFail(this);
        }

        public void PayProcess()
        {
            gateState.PayProcess(this);
        }

        public void PaySuccess()
        {
            gateState.PaySuccess(this);
        }

        public void PrintCurrentState()
        {
            gateState.PaySuccess(this);
        }
        
        public void ChangeGateState(IGateState gateState)
        {
            this.gateState = gateState;
        }
    }
}
