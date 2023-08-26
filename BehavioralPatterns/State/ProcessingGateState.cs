using System;

namespace BehavioralPatterns.State
{
    internal class ProcessingGateState : IGateState
    {
        public void Enter(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - PROCESSING, ACTION - NO CHANGE OF STATE");
        }

        public void PayFail(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - PROCESSING, ACTION - USER PAYMENT FAILED");

            gate.ChangeGateState(new CloseGateState());
        }

        public void PayProcess(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - PROCESSING, ACTION - NO CHANGE OF STATE");
        }

        public void PaySuccess(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - PROCESSING, ACTION - USER PAYMENT SUCCESS");

            gate.ChangeGateState(new OpenGateState());
        }
    }
}
