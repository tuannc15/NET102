namespace Slide617
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 9, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<String>() { "Mot", "Hai", null, "Ba", "Bon", "Nam" };
            IList<string> empList = new List<string>();
            Console.WriteLine(oneElementList.Single());
            Console.WriteLine(empList.SingleOrDefault());
            Console.WriteLine(intList.Single(x => x < 10));
            Console.ReadKey();
        }
    }
}