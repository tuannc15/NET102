namespace Slide613
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<String>() { null, "Mot", "Hai", "Ba", "Bon", "Nam" };
            IList<string> emptyList = new List<string>();
            Console.WriteLine(intList.Last());
            Console.WriteLine(intList.Last(x => x % 2 == 0));
            Console.WriteLine(strList.Last());
            //Console.WriteLine(emptyList.Last());
            Console.ReadKey();
        }
    }
}