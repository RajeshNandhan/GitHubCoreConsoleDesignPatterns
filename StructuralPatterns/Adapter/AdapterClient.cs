using System;

namespace StructuralPatterns.Adapter
{
    internal class AdapterClient
    {
        public static void AdapterClientTest()
        {
            bool canContinue;
            do
            {
                Console.WriteLine("Please enter D for Duck or L for Lion, or P for Pig\n");
                Console.WriteLine("Please enter any key except D, L, P, to exit\n\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                string userEnteredKey = consoleKeyInfo.Key.ToString().ToLower();
                canContinue = true;

                IAnimalAdapter animalAdapter = null;

                switch (userEnteredKey)
                {
                    case "l":
                        animalAdapter = new LionAnimalAdapter(new Lion()); //--Composition Adapter
                        break;
                    case "p":
                        animalAdapter = new PigAnimalAdapter();//-Inheritence Adapter
                        break;
                    case "d":
                        animalAdapter = new DuckAnimalAdapter(new Duck());//--Composition Adapter
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine("\n " + "Animal - " + animalAdapter.AnimalType() + ", Noise - " + animalAdapter.Speak() + ", Moves - " + animalAdapter.Move() + " \n");
                }
                else
                {
                    Console.WriteLine("\n thank you");
                }


            } while (canContinue);
        }

        public static void TestMethod()
        {
            AdapterClientTest();
        }
    }
}
