using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        List<List<int>> ints = new List<List<int>>();
        ints.Add(new List<int>() { 3, 5, 8 });
        ints.Add(new List<int>() { 11, 30, 20, 5, 10 });
        ints.Add(new List<int>() { 330, 22, 213 });

        foreach (int highest in FindLargest(ints))
        {
            Console.WriteLine(highest);
        }
    }
        public static List<int> FindLargest(List<List<int>> listInts)
        {
            List<int> result = new List<int>();

            foreach (List<int> ints in listInts)
            {
                ints.Sort();
                result.Add(ints[ints.Count - 1]);
            }
            return result;
        }
}