using System;

namespace BehavioralPatterns.State
{
    internal class StateClient
    {
        public static void SimulationMetroGate()
        {
            bool canContinue;
            MetroGate gate = new MetroGate();
            Console.WriteLine("This is a simulation program for metro gate.");

            do
            {
                Console.WriteLine("Press KEY E - Enter, F - Payemnt Failure, P - Payment Process, S - Payment success,  Any other key to exit.");

                ConsoleKeyInfo userSelectedKey = Console.ReadKey();
                string userSelectedKeyInLower = userSelectedKey.KeyChar.ToString().ToLower();
                canContinue = true;
                Console.WriteLine("\n");

                switch (userSelectedKeyInLower)
                {
                    case "e":
                        gate.Enter();
                        break;
                    case "f":
                        gate.PayFail();
                        break;
                    case "p":
                        gate.PayProcess();
                        break;
                    case "s":
                        gate.PaySuccess();
                        break;
                    default:
                        canContinue = false;
                        break;
                }
            } while (canContinue);
        }

        public static void TestMethod()
        {
            SimulationMetroGate();
        }
    }
}
