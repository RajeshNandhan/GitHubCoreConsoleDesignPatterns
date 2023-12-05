/// <summary>
/// DIVIDE AND CONQUER
/// </summary>
internal class MergeSortNumbers
{
    public static void TestMethod()
    {
        /*************** TEST 1 *************************/

        //int[] inputCOllection = { 11, 42, 9, 36, 74, 95, 26, 87, 102, 55, 10 };
        int[] inputCOllection = { 11, 42, 9, 36, 74, 95 };

        Console.WriteLine($"\nInput data array = {string.Join(", ", inputCOllection)}");

        int[] outputCOllection = SortNumbers(inputCOllection);

        Console.WriteLine($"Output data array = {string.Join(", ", outputCOllection)}");

        ///*************** TEST 2 *************************/

        //int[] inputCOllection2 = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };

        //Console.WriteLine($"\nInput data array = {string.Join(", ", inputCOllection2)}");

        //int[] outputCOllection2 = SortNumbers(inputCOllection2);

        //Console.WriteLine($"Output data array = {string.Join(", ", outputCOllection2)}");

        ///*************** TEST 3 *************************/

        //int[] inputCOllection3 = { 99, 88, 77, 66, 55, 44, 33, 22, 11 };

        //Console.WriteLine($"\nInput data array = {string.Join(", ", inputCOllection3)}");

        //int[] outputCOllection3 = SortNumbers(inputCOllection3);

        //Console.WriteLine($"Output data array = {string.Join(", ", outputCOllection3)}");

        ///*************** Exit *************************/

        Console.WriteLine("\n Press any key to exit");
        Console.ReadKey();
    }

    public static int[] SortNumbers(int[] inputArray)
    {
        if (inputArray.Length <= 1)
            return inputArray;

        var sortedArr = MergeSort(inputArray, 0, inputArray.Length - 1);

        return sortedArr;
    }

    private static int[] MergeSort(int[] inputArray, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int middle = (endIndex + startIndex) / 2;

            int[] leftArray = MergeSort(inputArray, startIndex, middle);

            Console.WriteLine($"\nleftArray = {string.Join(", ", leftArray)}");

            int[] rightArray = MergeSort(inputArray, middle + 1, endIndex);

            Console.WriteLine($"\nrightArray = {string.Join(", ", rightArray)}");

            int[] mergedArr = SortAndMergeArray(leftArray, rightArray);

            Console.WriteLine($"\nmergedArr = {string.Join(", ", mergedArr)}");

            return mergedArr;
        }

        return new int[] { inputArray[startIndex] };
    }

    /// <summary>
    /// This function will merge 2 ARRAYS into a single array
    /// In the process it will sort the items of array
    /// Returns a merged array which would be SORTED
    /// </summary>
    /// <param name="leftArray"></param>
    /// <param name="rightArray"></param>
    /// <returns></returns>
    private static int[] SortAndMergeArray(int[] leftArray, int[] rightArray)
    {
        //Create a array with size of 2 array to merge left and right array
        int[] mergedArray = new int[leftArray.Length + rightArray.Length];

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = 0;

        /* Traverse both leftArray and rightArray simultaneously and compare the values
         * Move the smaller to greater element of the arrays to mergedArray, hence
         * mergedArray will contain element of both leftArray and rightArray as single merged array and will be SORTED
         * example if rightArray = [5], leftArray = [6] then mergedArray = [5,6]
         */
        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                mergedArray[mergedIndex++] = leftArray[leftIndex++];
            }
            else
            {
                mergedArray[mergedIndex++] = rightArray[rightIndex++];
            }
        }

        /* If any elements remain in the leftArray not moved after merge, just append them to mergedArray */
        while (leftIndex < leftArray.Length)
        {
            mergedArray[mergedIndex++] = leftArray[leftIndex++];
        }

        /* If any elements remain in the rightArray not moved after merge, just append them to mergedArray
         * example: if rightArray = [5,9,10], leftArray = [6] then, after simultaneous sorting and marging of both leftArray and rightArray
         * mergedArray = [5,6] , rightArray = [9,10], leftArray = [], so can append [9,10] to  mergedArray in order to complete sorting
         */
        while (rightIndex < rightArray.Length)
        {
            mergedArray[mergedIndex++] = rightArray[rightIndex++];
        }

        return mergedArray;
    }
}