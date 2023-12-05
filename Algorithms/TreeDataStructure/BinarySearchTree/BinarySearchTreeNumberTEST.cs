namespace Algorithms.TreeDataStructure.BinarySearchTree
{
    internal class BinarySearchTreeNumberTest
    {
        public static void TestMethod()
        {
            IBinarySearchTreeNumber x = new BinarySearchTreeRecursiveNumber();
            //IBinarySearchTreeNumber x = new BinarySearchTreeIterativeNumber();
            TestMethod_Recursive(x);

            Console.ReadKey();
        }

        private static void TestMethod_Recursive(IBinarySearchTreeNumber x)
        {
            /****   Test 1 - ADD NODE  ******/


            List<int> inputList = new List<int>() { 23, 41, 190, 152, 39, 44, 43, 134, 181, 12, 175, 149, 189, 123, 144, 143, 126, 234, 111, 15, 1, 26, 256, 13, 271 };

            foreach (int i in inputList)
            {
                x.AddNode(i);
            }

            //Console.WriteLine($"\n Added Items[{inputList.Count()}] = {inputList.ConvertToString()}");
            Console.WriteLine($"\n Added Items (SORTED)[{inputList.Count()}] = {inputList.ConvertToStringSortedOrder()}");




            /****   Test 2 - NODE TRAVERSAL  ******/


            //var inOrderTraversal = x.GetInOrderTraversal();

            //Console.WriteLine($"\n--- Output - IN Order Traversal [{inOrderTraversal.Count()}]  = {inOrderTraversal.ConvertToString()}");

            //var preOrderTraversal = x.GetPreOrderTraversal();

            //Console.WriteLine($"\n--- Output - PRE Order Traversal [{preOrderTraversal.Count()}]  = {preOrderTraversal.ConvertToString()}");

            //var postOrderTraversal = x.GetPostOrderTraversal();

            //Console.WriteLine($"\n--- Output - POST Order Traversal [{postOrderTraversal.Count()}]  = {postOrderTraversal.ConvertToString()}");





            /****   Test 3  - DELETE NODE  ******/


            //// CASE 1 - ZERO CHILD CASE - Node that needs to be deleted has no CHILD in both left and right (NULL <- 5 -> NULL)
            x.DeleteNode(1);

            x.DeleteNode(271);

            // CASE 3 - ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node (26 <- 39 -> NULL)
            x.DeleteNode(39);

            // CASE 3 - ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node (NULL <- 234 -> 256)
            x.DeleteNode(234);

            ////TWO CHILD CASE - Node that needs to be deleted has both left and right nodes (44 <- 152 -> 181)
            x.DeleteNode(152);

            x.DeleteNode(134);

            x.DeleteNode(181);

            x.DeleteNode(123);

            var resultDeleteNode = x.GetInOrderTraversal();

            Console.WriteLine($"\n After DELETING 1, 271, 39, 234, 152, 134, 181, 123 \n --- Output Items [{resultDeleteNode.Count()}]  = {resultDeleteNode.ConvertToString()}");

            var matchFound = resultDeleteNode.SearchNumber(new List<int> { 1, 271, 39, 234, 152, 134, 181, 123 });

            if (matchFound)
            {
                Console.WriteLine($"\n delete FAILED");
            }
            else
            {
                Console.WriteLine($"\n delete SUCCESS");
            }




            /****   Test 3  - SEARCH NODE  ******/

            //var result44 = x.Search(44);

            //Console.WriteLine($"\n Find Node 44 = {result44?.Data}");

            //var result555 = x.Search(555);

            //Console.WriteLine($"\n Find Node 555 = {result555?.Data}");
        }
    }
}
