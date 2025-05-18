using Algorithms.Extensions;

namespace Algorithms.TreeDataStructure.BTree
{
    public class BTreeNumberTEST
    {
        public static void TestMethod()
        {
            BTreeNumber x = new BTreeNumber(2);

            //x.Insert(56);
            //x.Insert(29);
            //x.Insert(45);
            ////
            //x.Insert(11);
            //x.Insert(23);
            //x.Insert(34);
            ////
            //x.Insert(66);
            //x.Insert(9);
            //x.Insert(77);

            //x.Insert(175);
            //x.Insert(189);
            //x.Insert(123);

            //x.Insert(234);
            //x.Insert(111);
            //x.Insert(271);

            List<int> inputList1 = new List<int>() { 23, 41, 190, 152, 39, 44, 43, 134, 181, 12, 175, 149, 189, 123, 144, 143, 126, 234, 111, 15, 1, 26, 256, 13, 271, 167, 222, 56, 30, 6, 345, 115, 10 };

            List<int> inputList = new List<int>() { 23, 41, 190, 152, 39, 44, 43, 134, 181, 12, 175};

            foreach (int i in inputList)
            {
                x.Insert(i);
            }

            Console.WriteLine($"\n Input - Added Items (SORTED)[{inputList.Count()}] = {inputList.ConvertToStringSortedOrder()}");

            var inOrderTraversal = x.GetInOrderTraversal();

            Console.WriteLine($"\n Output - IN Order Traversal [{inOrderTraversal.Count()}]  = {inOrderTraversal.ConvertToString()}");



            /****   Test 3  - SEARCH NODE  ******/
            var result23 = x.Search(23);

            Console.WriteLine($"\n Find Node 134 = {result23}");

            var result134 = x.Search(134);

            Console.WriteLine($"\n Find Node 134 = {result134}");

            var result135 = x.Search(190);

            Console.WriteLine($"\n Find Node 190 = {result135}");

            Console.ReadKey();
        }
    }
}
