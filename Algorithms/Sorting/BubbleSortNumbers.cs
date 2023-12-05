namespace Algorithms.Sorting
{
    /// <summary>
    /// Bubble Sort modifies the INPUT array as it sorts the array
    /// Bubble Sort Algorithm works on iterates array elements
    /// Compares current element with next element and swaps the elements with in the array
    /// By swapping elements in the loop, elements are sorted
    /// The bubble sort algorithm has a time complexity of O(N²) as it has two nested loops
    /// </summary>
    internal class BubbleSortNumbers
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
        /// INPUT = 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10
        /// STEP 1 : Find the length of the Array
        /// STEP 2 : Compare the CURRENT element with NEXT element [CURRENT element = 11, NEXT element = 42]
        /// STEP 2 RESULT: 11 > 42
        /// STEP 3 : If CURRENT element greater then NEXT element, swap current element with next element, continue next
        /// STEP 4 : Compare the CURRENT element with NEXT element [CURRENT element = 42, NEXT element = 9]
        /// STEP 4 RESULT: 42 > 9 
        /// STEP 5 : If CURRENT element greater then NEXT element, swap current element with next element, continue next
        /// HENCE NEW ARRAY => 11, 9, 42, 36, 74, 95, 26, 87, 102, 55, 10
        /// STEP 6 : Compare the CURRENT element with NEXT element [CURRENT element = 42, NEXT element = 36]
        /// STEP 6 RESULT: 42 > 36
        /// STEP 7 : If CURRENT element greater then NEXT element, swap current element with next element, continue next
        /// HENCE NEW ARRAY => 11, 9, 36, 42, 74, 95, 26, 87, 102, 55, 10
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int[] SortNumbers(int[] inputArray)
        {
            int temp;
            int timeComplexityIndex = 0;
            var arrayLength = inputArray.Length;

            if (arrayLength <= 1)
                return inputArray;

            //TIME COMPLEXITY C1 = c1 * (n-2) times
            for (int i = 0; i <= arrayLength - 2; i++)
            {
                var check_sorting_done_in_previous_loop = false;

                //TIME COMPLEXITY C2 = ((n-1) + (n-2) + (n-3) ..+ 1) * c2 ???
                for (int j = 0; j < arrayLength - 1 - i; j++)
                {
                    //Check if current element is lessthan next element
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        temp = inputArray[j + 1];//move the next element to temp value
                        inputArray[j + 1] = inputArray[j]; //move element in the current position to next element place
                        inputArray[j] = temp; //move temp value that is previously next element to current element postion
                        check_sorting_done_in_previous_loop = true;
                    }

                    timeComplexityIndex = timeComplexityIndex + 1;
                }

                //Console.WriteLine($"\nInput data array = {string.Join(", ", inputArray)}");

                if (check_sorting_done_in_previous_loop == false)
                {
                    Console.WriteLine($"TIME COMPLEXITY [NUBER OF ITERATION] = {timeComplexityIndex}");
                    return inputArray;
                }
            }

            Console.WriteLine($"TIME COMPLEXITY [NUBER OF ITERATION] = {timeComplexityIndex}");

            return inputArray;
        }
    }
}

/*

Input data array = 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10

Input data array = 11, 9, 36, 42, 74, 26, 87, 95, 55, 10, 102

Input data array = 9, 11, 36, 42, 26, 74, 87, 55, 10, 95, 102

Input data array = 9, 11, 36, 26, 42, 74, 55, 10, 87, 95, 102

Input data array = 9, 11, 26, 36, 42, 55, 10, 74, 87, 95, 102

Input data array = 9, 11, 26, 36, 42, 10, 55, 74, 87, 95, 102

Input data array = 9, 11, 26, 36, 10, 42, 55, 74, 87, 95, 102

Input data array = 9, 11, 26, 10, 36, 42, 55, 74, 87, 95, 102

Input data array = 9, 11, 10, 26, 36, 42, 55, 74, 87, 95, 102

Input data array = 9, 10, 11, 26, 36, 42, 55, 74, 87, 95, 102

*/