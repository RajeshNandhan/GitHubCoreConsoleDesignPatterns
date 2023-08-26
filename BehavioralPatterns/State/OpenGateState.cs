using System;

namespace BehavioralPatterns.State
{
    internal class OpenGateState : IGateState
    {
        public void Enter(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - OPEN, ACTION - USER ALLOWED ENTER");

            gate.ChangeGateState(new CloseGateState());
        }

        public void PayFail(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - OPEN, ACTION - NO CHANGE OF STATE");
        }

        public void PayProcess(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - OPEN, ACTION - NO CHANGE OF STATE");
        }

        public void PaySuccess(IGate gate)
        {
            Console.WriteLine("CURRENT STATE - OPEN, ACTION - NO CHANGE OF STATE");
        }
    }
}
