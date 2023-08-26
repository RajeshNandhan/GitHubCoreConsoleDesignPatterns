using System;

namespace BehavioralPatterns.State
{
    internal class CloseGateState : IGateState
    {
        public void Enter(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - CLOSED, ACTION - NO CHANGE OF STATE");
        }

        public void PayFail(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - CLOSED, ACTION - NO CHANGE OF STATE");
        }

        public void PayProcess(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - CLOSED, ACTION - USER PAYMENT PROCESSING");

            gate.ChangeGateState(new ProcessingGateState());
        }

        public void PaySuccess(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - CLOSED, ACTION - NO CHANGE OF STATE");
        }
    }
}
