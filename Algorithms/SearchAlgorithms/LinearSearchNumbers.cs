namespace Algorithms.SearchAlgorithms
{
    /// <summary>
    /// NEED TO UPDATE WITH COMMENT FOR BIG O
    /// </summary>
    internal class LinearSearchNumbers
    {
        public static int LinearSearch_FindIndexOfTargetInCollection(int[] dataCollection, int targetValue)
        {
            //NUMBER OF ITERATION
            int timeComplexityIndex = 0;

            for (var i = 0; i < dataCollection.Length; i++)
            {
                timeComplexityIndex = timeComplexityIndex + 1;

                if (dataCollection[i] == targetValue)
                {
                    //item matched to target and quit iteration
                    return timeComplexityIndex;
                }
            }

            /*Target value not found after all the iteration*/
            return timeComplexityIndex;
        }

        public static void PrintResult(int indexFound)
        {
            Console.WriteLine($"NUMBER OF ITERATION DONE  = {indexFound} to FIND THE NUMBER");
        }

        public static void TestLinearSearch()
        {
            int[] inputCOllection = { 11, 42, 36, 74, 95, 26, 87, 102, 55, 9 };
            Console.WriteLine($"Input data (10) = {string.Join(", ", inputCOllection)}");

            //
            Console.WriteLine("\n Test BEST CASE (POSITIVE) ; FInd number 11 in above collection input");

            int Input1 = 11;
            int Output1 = LinearSearch_FindIndexOfTargetInCollection(inputCOllection, Input1);
            PrintResult(Output1);

            //
            Console.WriteLine("\n Test WORST CASE (POSITIVE) ; FInd number 9 in above collection input");

            int Input2 = 9;
            int Output2 = LinearSearch_FindIndexOfTargetInCollection(inputCOllection, Input2);
            PrintResult(Output2);

            //
            Console.WriteLine("\n Test NEGATIVE CASE to FInd number 99 in above collection input");

            int Input3 = 99;
            int Output3 = LinearSearch_FindIndexOfTargetInCollection(inputCOllection, Input3);
            PrintResult(Output3);

            //
            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
        }

        public static void TestMethod()
        {
            TestLinearSearch();
        }
    }
}
