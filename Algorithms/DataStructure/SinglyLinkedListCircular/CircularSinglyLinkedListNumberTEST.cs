namespace Algorithms.DataStructure.CircularSinglyLinkedList
{
    internal class CircularSinglyLinkedListNumberTEST
    {
        public static void TestMethod()
        {
            CircularSinglyLinkedListNumber x = new CircularSinglyLinkedListNumber();

            x.Add(23);
            x.Add(45);
            x.Add(13);
            x.Add(78);
            x.Add(56);

            Console.WriteLine($"\n Items added 23,45,13,78,56 [{x.GetCount()}] = {x}");


            x.Insert(345, 0);
            x.Insert(11, 1);
            x.Insert(29, 4);
            x.Insert(61, 6);
            x.Insert(22, 23);//NEGATIVE CASE
            x.Insert(77, 3);
            x.Insert(66, 10);//EDGE CASE ADDING TO LAST NODE
            x.Insert(632, 12);//NEGATIVE CASE
            x.Add(33);

            Console.WriteLine($"\n After Adding 345(0) 11(1) , 29(4), 61(6), !22(23), 77(3), 66(10) 632(12) 33(END) Items = [{x.GetCount()}]  = {x}");


            x.Remove(11);
            x.Remove(78);
            x.Remove(5);//NEGATIVE CASE
            x.Remove(345);
            x.Remove(33);
            x.Add(44);

            Console.WriteLine($"\n After Removing 11, 78 5, 345, 33 Items [{x.GetCount()}]  = {x}");


            x.Reverse();

            Console.WriteLine($"\n After Reverse Items [{x.GetCount()}]  = {x}");

            Console.ReadKey();
        }
    }
}
