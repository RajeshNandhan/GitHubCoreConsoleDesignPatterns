namespace Algorithms.DataStructure.SinglyLinkedList
{
    internal class SinglyLinkedListNumberTEST
    {
        public static void TestMethod()
        {
            SinglyLinkedListNumber x = new SinglyLinkedListNumber();

            //
            x.Add(23);
            x.Add(45);
            x.Add(13);
            x.Add(78);
            x.Add(56);

            Console.WriteLine($"\n Items added 23,45,13,78,56 [{x.GetCount()}] = {x}");

            //
            x.Insert(345, 0);
            x.Insert(29, 4);
            x.Insert(61, 6);
            x.Insert(22, 23);//NEGATIVE CASE
            x.Insert(77, 3);
            x.Insert(66, 9);//EDGE CASE ADDING TO LAST NODE
            x.Add(33);

            Console.WriteLine($"\n After Adding 345(1) , 29(4), 61(6), !22(23), 77(3), 66(9) 33(END) Items = [{x.GetCount()}]  = {x}");

            //
            x.Remove(13);
            x.Remove(78);
            x.Remove(5);//NEGATIVE CASE
            x.Remove(345);
            x.Remove(33);
            x.Add(44);

            Console.WriteLine($"\n After Removing 13, 78 5, 345, 33 Items [{x.GetCount()}]  = {x}");

            //
            x.Reverse();

            Console.WriteLine($"\n After Reverse Items [{x.GetCount()}]  = {x}");

            Console.ReadKey();
        }
    }
}
