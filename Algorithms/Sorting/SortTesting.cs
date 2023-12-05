namespace Algorithms.Sorting
{
    internal class SortTesting
    {
        public static void TestMethod()
        {
            int[] inputCOllection = { 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 9 };
            int[] outputCOllection = inputCOllection.OrderBy(x => x).ToArray();

            Console.WriteLine(VerifySortingAlgorithim_LoopWay(inputCOllection));
            Console.WriteLine(VerifySortingAlgorithim_LoopWay(outputCOllection));

            Console.WriteLine(VerifySortingAlgorithim_RecursiveWay(inputCOllection));
            Console.WriteLine(VerifySortingAlgorithim_RecursiveWay(outputCOllection));

            Console.WriteLine($"Input data array = {string.Join(", ", inputCOllection)}");
            Console.WriteLine($"Input data array = {string.Join(", ", outputCOllection)}");

            //
            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
        }


        /// <summary>
        ///  This function will test if a given array in sorting order
        ///  INPUT = 11, 42, 74,36, 95, 26, 87, 102, 55, 9
        ///  PROGRAM STEP 1: TAKE FIRST and SECOND elements from the array and check "FIRST" LessThan "SECOND"
        ///  STEP 1 ? 11 < 42 == true
        ///  PROGRAM STEP 2: if "FIRST" LessThan "SECOND" is TRUE reset the ARRAY by removing FIRST element and keep all the elements
        ///  STEP 2 ? NEW ARRAY = 42, 74,36, 95, 26, 87, 102, 55, 9
        ///  PROGRAM STEP 3: TAKE FIRST and SECOND elements from the NEW array and check "FIRST" LessThan "SECOND"
        ///  STEP 3 ? 42 < 74 == true
        ///  PROGRAM STEP 4: if "FIRST" LessThan "SECOND" is TRUE reset the ARRAY by removing FIRST element and keep all the elements
        ///  STEP 4 ? NEW ARRAY = 74,36, 95, 26, 87, 102, 55, 9
        ///  PROGRAM STEP 5: TAKE FIRST and SECOND elements from the NEW array and check "FIRST" LessThan "SECOND"
        ///  STEP 3 ? 74 < 36 == FALSE
        ///  EXIT THE iteration and Array not sorted
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static bool VerifySortingAlgorithim_RecursiveWay(int[] inputArray)
        {
            var arrayLength = inputArray.Length;

            //if given ARRAY has 0 or 1 element assume its already sorted
            //Stopping Condition
            if (arrayLength == 0 || arrayLength == 1)
                return true;

            if (inputArray[0] <= inputArray[1])
            {
                //ITERATION WILL CONTINUE TILL LENGTH IS ZERO OR ONE [LAST ELEMENT]
                return VerifySortingAlgorithim_RecursiveWay(inputArray.Skip(1).Take(arrayLength).ToArray());
            }
            else
            {
                //ITEARTION ENDS AS DATA NOT SORTED
                return false;
            }
        }

        public static bool VerifySortingAlgorithim_LoopWay(int[] inputArray)
        {
            var counter = 0;

            while (counter < inputArray.Length - 1)
            {
                if (inputArray[counter] > inputArray[counter + 1])
                {
                    return false;
                }
                else
                {
                    counter++;
                }
            }

            return true;
        }
    }
}
