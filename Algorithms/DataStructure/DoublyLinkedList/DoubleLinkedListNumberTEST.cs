namespace Algorithms.DataStructure.DoublyLinkedList
{
    internal class DoubleLinkedListNumberTEST
    {
        public static void TestMethod()
        {
            DoubleLinkedListNumber x = new DoubleLinkedListNumber();

            x.Add(23);
            x.Add(45);
            x.Add(13);
            x.Add(78);
            x.Add(56);

            Console.WriteLine($"\n Items [{x.GetCount()}] = {x}");

            x.Insert(345, 0);
            x.Insert(29, 1);
            x.Insert(81, 4);
            x.Insert(61, 6);
            x.Insert(22, 23);//NEGATIVE CASE
            x.Insert(77, 3);
            x.Insert(66, 9);//ADDING TO LAST NODE - 9 IS THE LAST INDEX

            Console.WriteLine($"\n After Adding 345(1) , 29(1), 81(4), 61(6), !22(23), 77(3), 66(9) Items = [{x.GetCount()}]  = {x}");

            x.Remove(13);
            x.Remove(78);
            x.Remove(5);//NEGATIVE CASE
            x.Remove(345);

            Console.WriteLine($"\n After Removing 13, 78 5, 345 Items [{x.GetCount()}]  = {x}");

            x.Reverse();

            Console.WriteLine($"\n After Reverse Items [{x.GetCount()}]  = {x}");

            Console.ReadKey();
        }
    }
}
