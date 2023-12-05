namespace Algorithms.SearchAlgorithms
{
    /// <summary>
    /// NEED TO UPDATE WITH COMMENT FOR BIG O
    /// ITERATIVE way of doing things 
    /// SPace complexity for collection handling is O(1) constant space since no additional collection created
    /// INPUT = 11, 42, 36, 74, 95, 26, 87, 102, 55, 9, FIND NUMBER = 102
    /// PROGRAM STEP 1 : SORT INPUT => 9, 11, 26, 36, 42, 55, 74, 87, 95, 102
    /// PROGRAM STEP 2 : FIND THE "MID ITEM" AND COMPARE IT WITH "TARGET", IF BOTH MATCH RETURN
    /// STEP 2 ? 42 == 102
    /// PROGRAM STEP 3 : IF NOT MATCHED, CHECK "TARGET" IS BIGGER THEN "MID ITEM", IF IT IS TRUE SPLIT ARRAY FROM MID ITEM TO LAST ITEM
    /// STEP 3 ? NEW ARRAY = 55, 74, 87, 95, 102
    /// PROGRAM STEP 4 : FIND THE "MID ITEM" OF NEW ARRAY AND COMPARE IT WITH "TARGET", IF BOTH MATCH RETURN
    /// STEP 4 ? 87 == 102 
    /// PROGRAM STEP 5 : IF NOT MATCHED, CHECK "TARGET" IS BIGGER THEN "MID ITEM", IF IT IS TRUE SPLIT ARRAY FROM MID ITEM TO LAST ITEM
    /// STEP 5 ? NEW ARRAY = 95, 102
    /// PROGRAM STEP 6 : FIND THE "MID ITEM" OF NEW ARRAY AND COMPARE IT WITH "TARGET", IF BOTH MATCH RETURN
    /// STEP 6 ? 95 == 102 
    /// PROGRAM STEP 7 : IF NOT MATCHED, CHECK "TARGET" IS BIGGER THEN "MID ITEM", IF IT IS TRUE SPLIT ARRAY FROM MID ITEM TO LAST ITEM
    /// STEP 7 ? NEW ARRAY = 102
    /// PROGRAM STEP 8 : FIND THE "MID ITEM" OF NEW ARRAY AND COMPARE IT WITH "TARGET", IF BOTH MATCH RETURN
    /// STEP 8 ? 102 == 102
    /// 
    /// MID ITEM INDEX = START INDEX[0] + LAST INDEX[LENGTH]/2
    /// NUBER OF ITERATION IS TIME COMPLEXITY, IN THIS CASE BIG O = logn
    /// </summary>
    internal class BinarySearchNumbers
    {
        public static int BinarySearch_FindIndexOfTargetInCollection(int[] dataCollection, int targetValue)
        {
            int timeComplexityIndex = 0;

            //SORTING INPUT COLLECTION DATA IS MANADATORY for Binary Search
            int[] dataCollectionSorted = dataCollection.OrderBy(x => x).ToArray<int>();

            int firstItemIndex = 0;

            int lastItemIndex = dataCollectionSorted.Length - 1;

            while (firstItemIndex <= lastItemIndex)
            {
                //NUMBER OF ITERATION IS THE TIME COMPLEXITY
                timeComplexityIndex = timeComplexityIndex + 1;

                int middleItemIndex = (firstItemIndex + lastItemIndex) / 2;

                if (dataCollectionSorted[middleItemIndex] == targetValue)
                {
                    //item matched to target and quit iteration and return back
                    return timeComplexityIndex;
                }

                if (targetValue < dataCollectionSorted[middleItemIndex])
                {
                    /*Serching target item may be there in the 1st half of the current collection*/
                    /*Divide the collection 2 HALF*/
                    /*Continue the iteration*/
                    lastItemIndex = middleItemIndex - 1;
                }
                else
                {
                    /*Serching target item may be there in the 2nd half of the current collection*/
                    /*Divide the collection 2 HALF*/
                    /*Continue the iteration*/
                    firstItemIndex = middleItemIndex + 1;
                }
            }

            /*Target value not found after all the iteration*/
            /*so quit iteration and retun back*/
            return timeComplexityIndex;
        }

        public static void PrintResult(int indexFound)
        {
            Console.WriteLine($"NUMBER OF ITERATION DONE  = {indexFound} to FIND THE NUMBER");
        }

        public static void TestBinarySearch()
        {
            int[] inputCOllection = { 11, 42, 36, 74, 95, 26, 87, 102, 55, 9 };
            Console.WriteLine($"Input data [10] = {string.Join(", ", inputCOllection)}");
            Console.WriteLine($"Input data[10] after sorting = {string.Join(", ", inputCOllection.OrderBy(x => x).ToArray<int>())}");

            //
            Console.WriteLine("\n\n Test BEST CASE (POSITIVE) ; FInd number 42 in above collection input");

            int Input1 = 42;
            int Output1 = BinarySearch_FindIndexOfTargetInCollection(inputCOllection, Input1);
            PrintResult(Output1);

            //
            Console.WriteLine("\n Test CASE (POSITIVE) ; FInd number 102 in above collection input");

            int Input2 = 102;
            int Output2 = BinarySearch_FindIndexOfTargetInCollection(inputCOllection, Input2);
            PrintResult(Output2);

            //
            Console.WriteLine("\n Test CASE (POSITIVE) ; FInd number 9 in above collection input");

            int Input3 = 9;
            int Output3 = BinarySearch_FindIndexOfTargetInCollection(inputCOllection, Input3);
            PrintResult(Output3);

            //
            Console.WriteLine("\n Test CASE (POSITIVE) ; FInd number 55 in above collection input");

            int Input4 = 55;
            int Output4 = BinarySearch_FindIndexOfTargetInCollection(inputCOllection, Input4);
            PrintResult(Output4);

            //
            Console.WriteLine("\n Test NEGATIVE CASE to FInd number 99 in above collection input");

            int Input5 = 99;
            int Output5 = BinarySearch_FindIndexOfTargetInCollection(inputCOllection, Input5);
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
