namespace Algorithms.DataStructure.SinglyLinkedListStacked
{
    internal class StackedSinglyLinkedListNumberTEST
    {
        public static void TestMethod()
        {
            StackedSinglyLinkedListNumber x = new StackedSinglyLinkedListNumber();

            //
            x.Push(23);
            x.Push(45);
            x.Push(13);
            x.Push(78);
            x.Push(56);

            Console.WriteLine($"\n Items PUSH 23,45,13,78,56 [{x.GetCount()}] = {x}");

            //
            x.Pop();
            x.Pop();

            Console.WriteLine($"\n After Removing 78, 56 Items [{x.GetCount()}]  = {x}");

            Console.ReadKey();
        }
    }
}
