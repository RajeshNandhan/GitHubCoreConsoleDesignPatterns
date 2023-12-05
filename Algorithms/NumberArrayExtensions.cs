using System.Text;

namespace Algorithms
{
    public static class NumberArrayExtensions
    {
        public static string ConvertToString(this List<int> input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (int i in input)
            {
                stringBuilder.Append(i.ToString() + " , ");
            }

            return stringBuilder.ToString();
        }

        public static string ConvertToStringSortedOrder(this List<int> input)
        {
            List<int> inputSorted = input.OrderBy(x => x).ToList();

            return ConvertToString(inputSorted);
        }

        public static bool SearchNumber(this List<int> input, List<int> searchInput)
        {
            foreach (int i in searchInput)
            {
                if (input.Find(x => x == i) > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
