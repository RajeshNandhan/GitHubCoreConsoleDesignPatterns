namespace Algorithms.SearchAlgorithms
{
    /// <summary>
    /// NEED TO UPDATE WITH COMMENT FOR BIG O
    /// //SORTING INPUT COLLECTION DATA IS MANADATORY for Binary Search
    /// RECURSIVE WAY OF DOING THINGS
    /// SPace complexity for collection handling is O(log n) since additional collection created for each recursive calls
    /// collection created for each recursive calls (n, n/2, n/4, n/8...)
    /// what is tail optimization
    /// SPace complexity for programing language
    /// </summary>
    internal class BinarySearchRecursiveNumbers
    {
        public static int timeComplexityIndex = 0;

        public static int BinarySearch_FindIndexOfTargetInCollection(int[] dataCollectionSorted, int targetValue)
        {
            int lastItemIndex = dataCollectionSorted.Length;
            int middleItemIndex = dataCollectionSorted.Length / 2;

            //STOPING CONDITION
            if (lastItemIndex == 0)
            {
                //item not found for target after all the recursion possible,
                //array is empty now, so quit recursion and retun back
                return timeComplexityIndex;
            }
            else
            {
                timeComplexityIndex = timeComplexityIndex + 1;

                if (dataCollectionSorted[middleItemIndex] == targetValue)
                {
                    //item matched to target and quit the recursion and retun back
                    return timeComplexityIndex;
                }

                if (targetValue > dataCollectionSorted[middleItemIndex])
                {
                    /*Serching target item may be there in the 2nd half of the current collection*/
                    /*Divide the collection 2 HALF and PASS the Second collection of values*/
                    /*continue the recursion*/

                    var slicedPosts = dataCollectionSorted.Skip(middleItemIndex + 1).Take(lastItemIndex);
                    return BinarySearch_FindIndexOfTargetInCollection(slicedPosts.ToArray(), targetValue);
                }
                else
                {
                    /*Serching target item may be there in the 1st half of the current collection*/
                    /*Divide the collection 2 HALF and PASS the First collection of values*/
                    /*continue the recursion*/

                    var slicedPosts = dataCollectionSorted.Take(middleItemIndex);
                    return BinarySearch_FindIndexOfTargetInCollection(slicedPosts.ToArray(), targetValue);
                }
            }
        }

        public static void PrintResult(int indexFound)
        {
            Console.WriteLine($"NUMBER OF RECURSION DONE  = {indexFound} to FIND THE NUMBER");
        }

        public static void TestBinarySearch()
        {
            int[] inputCollection = { 11, 42, 36, 74, 95, 26, 87, 102, 55, 9 };
            Console.WriteLine($"Input data [10] = {string.Join(", ", inputCollection)}");

            //SORTING INPUT COLLECTION DATA IS MANADATORY for Binary Search
            int[] dataCollectionSorted = inputCollection.OrderBy(x => x).ToArray();
            Console.WriteLine($"Input data[10] after sorting = {string.Join(", ", dataCollectionSorted.OrderBy(x => x).ToArray<int>())}");

            //
            Console.WriteLine("\n\n Test BEST CASE (POSITIVE) ; FInd number 42 in above collection input");

            int Input1 = 42;
            timeComplexityIndex = 0;//RESETTING THE TIME COMPLEXITY
            int Output1 = BinarySearch_FindIndexOfTargetInCollection(dataCollectionSorted, Input1);
            PrintResult(Output1);

            //
            Console.WriteLine("\n Test CASE (POSITIVE) ; FInd number 102 in above collection input");

            int Input2 = 102;
            timeComplexityIndex = 0;//RESETTING THE TIME COMPLEXITY
            int Output2 = BinarySearch_FindIndexOfTargetInCollection(dataCollectionSorted, Input2);
            PrintResult(Output2);

            //
            Console.WriteLine("\n Test CASE (POSITIVE) ; FInd number 9 in above collection input");

            int Input3 = 9;
            timeComplexityIndex = 0;//RESETTING THE TIME COMPLEXITY
            int Output3 = BinarySearch_FindIndexOfTargetInCollection(dataCollectionSorted, Input3);
            PrintResult(Output3);

            //
            Console.WriteLine("\n Test CASE (POSITIVE) ; FInd number 55 in above collection input");

            int Input4 = 55;
            timeComplexityIndex = 0;//RESETTING THE TIME COMPLEXITY
            int Output4 = BinarySearch_FindIndexOfTargetInCollection(dataCollectionSorted, Input4);
            PrintResult(Output4);

            //
            Console.WriteLine("\n Test NEGATIVE CASE to FInd number 99 in above collection input");

            int Input5 = 99;
            timeComplexityIndex = 0;//RESETTING THE TIME COMPLEXITY
            int Output5 = BinarySearch_FindIndexOfTargetInCollection(dataCollectionSorted, Input5);
            PrintResult(Output5);

            //
            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
        }

        public static void TestMethod()
        {
            TestBinarySearch();
        }
    }
}
