namespace Slide614
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] objList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] objVal = { };
            int result = objList.LastOrDefault();
            int val = objVal.LastOrDefault();
            int val1 = (from x in objVal select x).LastOrDefault();

            Console.WriteLine(result);
            Console.WriteLine(val);
            Console.WriteLine(val1);
            Console.WriteLine();

            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<String>() { "Mot", "Hai", null, "Ba", "Bon", "Nam" };
            //Console.WriteLine(intList.Last(x => x > 250).ToString());
            // Console.WriteLine(strList.LastOrDefault(s => s.Contains("B")));
            Console.ReadKey();
        }
    }
}