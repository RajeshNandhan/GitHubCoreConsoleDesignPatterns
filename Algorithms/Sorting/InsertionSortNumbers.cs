namespace Algorithms.Sorting
{
    /// <summary>
    /// Insertion Sort creates or divides array into 2 parts such as sorted and unsorted 
    /// It iterates array and picks a elements and compares with next element of unsorted side [in this case left side]
    /// based on the value of element it position the selelcted element, which keeps elements sorted
    /// Insertion modifies the input array so input array will be sorted post sorting call
    /// </summary>
    internal class InsertionSortNumbers
    {
        public static void TestMethod()
        {
            /*************** TEST 1 *************************/

            int[] inputCOllection = { 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10 };

            Console.WriteLine($"\nInput data array = {string.Join(", ", inputCOllection)}");

            SortNumbers(inputCOllection);

            Console.WriteLine($"Output data array = {string.Join(", ", inputCOllection)}");

            /*************** TEST 2 *************************/

            int[] inputCOllection2 = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };

            Console.WriteLine($"\nInput data array = {string.Join(", ", inputCOllection2)}");

            SortNumbers(inputCOllection2);

            Console.WriteLine($"Output data array = {string.Join(", ", inputCOllection2)}");

            /*************** TEST 3 *************************/

            int[] inputCOllection3 = { 99, 88, 77, 66, 55, 44, 33, 22, 11 };

            Console.WriteLine($"\nInput data array = {string.Join(", ", inputCOllection3)}");

            SortNumbers(inputCOllection3);

            Console.WriteLine($"Output data array = {string.Join(", ", inputCOllection3)}");

            /*************** Exit *************************/

            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        ///  INPUT = 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10
        ///  STEP 1 : Find the length of the Array
        ///  STEP 1 : current index = 1
        ///  STEP 1 : CHeck if element of current index is in correct position of the left side of its adjacent elements [left side array elements]
        ///  example - array [42, 9, 74, 36 ] and element 36 should be postioned before 42 so right order will be [36, 42, 74, 9] for element 36
        ///  STEP 1 : current index = 1, current value = 42, maxLeftSidePositionToCurrentIndex = 1-1 = 0, left side arrays = 11
        ///  STEP 1 RESULT: [11] > 42 ?  NO SWAPPING
        ///  HENCE NEW ARRAY [NO CHANGES] => 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10
        ///  
        ///  continue next
        ///  STEP 1 : current index = 2
        ///  STEP 2 : CHeck if element of current index is in correct position of the left side of its adjacent elements [left side array elements]
        ///  STEP 2 : current index = 2, current value = 9, maxLeftSidePositionToCurrentIndex = 2-1 = 1, left side arrays = 11, 42
        ///  STEP 2 RESULT: [11, 42] > 9 ? SWAPPING
        ///  HENCE NEW ARRAY => 9, 11, 42, 36, 74, 95, 26, 87, 102, 55, 10
        ///  continue next
        ///  
        ///  STEP 1 : current index = 3
        ///  STEP 2 : CHeck if element of current index is in correct position of the left side of its adjacent elements [left side array elements]
        ///  STEP 2 : current index = 3, current value = 36, maxLeftSidePositionToCurrentIndex = 3-1 = 2, left side arrays = 9, 11, 42
        ///  STEP 2 RESULT: [9, 11, 42] > 36 ? SWAPPING
        ///  HENCE NEW ARRAY => 9, 11, 36, 42, 74, 95, 26, 87, 102, 55, 10
        ///  continue next
        ///  
        ///  STEP 1 : current index = 4
        ///  STEP 2 : CHeck if element of current index is in correct position of the left side of its adjacent elements [left side array elements]
        ///  STEP 2 : current index = 4, current value = 74, maxLeftSidePositionToCurrentIndex = 4-1 = 3, left side arrays = 9, 11, 36, 42
        ///  STEP 2 RESULT: [9, 11, 36, 42] > 74 ? NO SWAPPING
        ///  HENCE NEW ARRAY [NO CHANGES] =>  9, 11, 36, 42, 74, 95, 26, 87, 102, 55, 10
        ///  continue next
        ///  
        ///  STEP 1 : current index = 5
        ///  STEP 2 : CHeck if element of current index is in correct position of the left side of its adjacent elements [left side array elements]
        ///  STEP 2 : current index = 5, current value = 95, maxLeftSidePositionToCurrentIndex = 5-1 = 4, left side arrays = 9, 11, 36, 42, 74
        ///  STEP 2 RESULT: [9, 11, 36, 42, 74] > 95 ? NO SWAPPING
        ///  HENCE NEW ARRAY [NO CHANGES] =>  9, 11, 36, 42, 74, 95, 26, 87, 102, 55, 10
        ///  continue next
        ///  
        ///  STEP 1 : current index = 6
        ///  STEP 2 : CHeck if element of current index is in correct position of the left side of its adjacent elements [left side array elements]
        ///  STEP 2 : current index = 6, current value = 26, maxLeftSidePositionToCurrentIndex =6-1 = 5, left side arrays = 9, 11, 36, 42, 74, 95
        ///  STEP 2 RESULT: [9, 11, 36, 42, 74, 95] > 26 ? SWAPPING
        ///  HENCE NEW ARRAY =>  9, 11, 26, 36, 42, 74, 95, 87, 102, 55, 10
        ///  continue next
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int[] SortNumbers(int[] inputArray)
        {
            int timeComplexityIndex = 0;

            //TIME COMPLEXITY C1 = c1 * (n-1) times
            for (int i = 1; i < inputArray.Length; ++i)
            {
                int currentValue = inputArray[i];
                int maxLeftSidePositionToCurrentIndex = i - 1;

                //REVERS COMPARISON SHOULD GO TILL ZERO INDEX
                //TIME COMPLEXITY C2 = (1 + 2 + 3 ..+ (n-1)) * c2
                //TIME COMPLEXITY C2 = n * ((n-1)/2) * c2
                while (maxLeftSidePositionToCurrentIndex >= 0 && inputArray[maxLeftSidePositionToCurrentIndex] > currentValue)
                {
                    inputArray[maxLeftSidePositionToCurrentIndex + 1] = inputArray[maxLeftSidePositionToCurrentIndex];
                    maxLeftSidePositionToCurrentIndex -= 1;

                    timeComplexityIndex = timeComplexityIndex + 1;
                }

                inputArray[maxLeftSidePositionToCurrentIndex + 1] = currentValue;

                //Console.WriteLine($"\nStage data array = {string.Join(", ", inputArray)}");
            }

            Console.WriteLine($"TIME COMPLEXITY [NUBER OF ITERATION] = {timeComplexityIndex}");

            return inputArray;
        }
    }
}

/*

Stage data array = 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10

Stage data array = 9, 11, 42, 36, 74, 95, 26, 87, 102, 55, 10

Stage data array = 9, 11, 36, 42, 74, 95, 26, 87, 102, 55, 10

Stage data array = 9, 11, 36, 42, 74, 95, 26, 87, 102, 55, 10

Stage data array = 9, 11, 36, 42, 74, 95, 26, 87, 102, 55, 10

Stage data array = 9, 11, 26, 36, 42, 74, 95, 87, 102, 55, 10

Stage data array = 9, 11, 26, 36, 42, 74, 87, 95, 102, 55, 10

Stage data array = 9, 11, 26, 36, 42, 74, 87, 95, 102, 55, 10

Stage data array = 9, 11, 26, 36, 42, 55, 74, 87, 95, 102, 10

*/