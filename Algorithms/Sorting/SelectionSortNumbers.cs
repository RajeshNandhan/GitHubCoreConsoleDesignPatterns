namespace Algorithms.Sorting
{
    /// <summary>
    /// BubbleSort modifies the input array so input array will be sorted post sorting call
    /// Selection sort algorithm basically iterates the given array
    /// On each iteration identifys the INDEX of the smallest number
    /// On each iteration SWAPS the smallest number of array
    /// SWAPPING OF elements done FROM STARTING OF The array elements with elements of Identified INDEX position
    /// </summary>
    internal class SelectionSortNumbers
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
        /// STEP 2 : IDENTIFY smallest Value Index Position
        /// STEP 3 RESULT : smallestValueIndexPosition = 3,
        /// STEP 4 : COPY smallest number to temp variable for swapping, That is COPY the element[3] to temp variable 
        /// STEP 4 RESULT : tempVariable = 9,
        /// STEP 5 : MOVE CURRENT INDEX ELEMENT to element of smallestValueIndexPosition INDEX in the ARRAY
        /// STEP 5 RESULT : CURRENT ARRAY INDEX = 0, inputArray[3] = inputArray[0], inputArray[3] = 11
        /// STEP 6: COPY THE SMALLEST NUMER to CURRENT INDEX ELEMENT
        /// STEP 6 RESULT :inputArray[0] = 9
        /// HENCE NEW ARRAY => 9, 42, 11, 36, 74, 95, 26, 87, 102, 55, 10
        /// ITERATION CONTINUES
        /// STEP 7 : IDENTIFY smallest Value Index Position
        /// STEP 8 RESULT : smallestValueIndexPosition = 11,
        /// STEP 4 : COPY smallest number to temp variable for swapping, That is COPY the element[11] to temp variable 
        /// STEP 4 RESULT : tempVariable = 10,
        /// STEP 5 : MOVE CURRENT INDEX ELEMENT to element of smallestValueIndexPosition INDEX in the ARRAY
        /// STEP 5 RESULT : CURRENT ARRAY INDEX = 1, inputArray[11] = inputArray[1], inputArray[11] = 10
        /// STEP 6: COPY THE SMALLEST NUMER to CURRENT INDEX ELEMENT
        /// STEP 6 RESULT :inputArray[1] = 10
        /// HENCE NEW ARRAY => 9, 10, 11, 36, 74, 95, 26, 87, 102, 55, 42
        /// ITERATION CONTINUES
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int[] SortNumbers(int[] inputArray)
        {
            //NUBER OF ITERATION IS TIME COMPLEXITY, IN THIS CASE BIG O = O(N^2)
            int timeComplexityIndex = 0;
            var arrayLength = inputArray.Length;

            if (arrayLength <= 1)
                return inputArray;

            //TIME COMPLEXITY C1 = c1 * (n-1) times
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestValueIndexPosition = i;

                //TIME COMPLEXITY C2 = (n-1) + (n-2) + (n-3) + .. 1 times
                //TIME COMPLEXITY C2 = c2 * n(n-1)/2
                for (int j = i + 1; j < arrayLength; j++)
                {
                    timeComplexityIndex = timeComplexityIndex + 1;

                    if (inputArray[j] < inputArray[smallestValueIndexPosition])
                    {
                        smallestValueIndexPosition = j;
                    }
                }

                //TIME COMPLEXITY C3 = c3 * (n-1) times
                var tempVariable = inputArray[smallestValueIndexPosition];
                inputArray[smallestValueIndexPosition] = inputArray[i];
                inputArray[i] = tempVariable;

                Console.WriteLine($"\nInput data array = {string.Join(", ", inputArray)}");
            }

            //TIME COMPLEXITY C = c1 * (n-1) + c2 * (n(n-1)/2) + c3 * (n-1) 
            //TIME COMPLEXITY C = an^2 + bn + c => O(n^2)
            //c1,c2,c3 = some constant
            Console.WriteLine($"TIME COMPLEXITY [NUBER OF ITERATION] = {timeComplexityIndex}");
            return inputArray;
        }
    }
}

/*

Input data array = 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10

Input data array = 9, 42, 11, 36, 74, 95, 26, 87, 102, 55, 10

Input data array = 9, 10, 11, 36, 74, 95, 26, 87, 102, 55, 42

Input data array = 9, 10, 11, 36, 74, 95, 26, 87, 102, 55, 42

Input data array = 9, 10, 11, 26, 74, 95, 36, 87, 102, 55, 42

Input data array = 9, 10, 11, 26, 36, 95, 74, 87, 102, 55, 42

Input data array = 9, 10, 11, 26, 36, 42, 74, 87, 102, 55, 95

Input data array = 9, 10, 11, 26, 36, 42, 55, 87, 102, 74, 95

Input data array = 9, 10, 11, 26, 36, 42, 55, 74, 102, 87, 95

Input data array = 9, 10, 11, 26, 36, 42, 55, 74, 87, 102, 95

Input data array = 9, 10, 11, 26, 36, 42, 55, 74, 87, 95, 102

*/