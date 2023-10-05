namespace Slide616
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<String>() { "Mot", "Hai", null, "Ba", "Bon", "Nam" };
            Console.WriteLine(intList.ElementAt(0));
            Console.WriteLine(strList.ElementAt(0));
            Console.WriteLine(intList.ElementAt(1));
            Console.WriteLine(strList.ElementAt(1));
            Console.WriteLine(intList.ElementAtOrDefault(2));
            Console.WriteLine(strList.ElementAtOrDefault(2));
            Console.WriteLine("Vi tri thu 10");
            Console.WriteLine(intList.ElementAtOrDefault(9));
            Console.WriteLine(strList.ElementAtOrDefault(9));

            Console.WriteLine("Bao loi");
            //Console.WriteLine(strList.ElementAt(9));
            int i = 9;
            if (i < intList.Count())
            {
                Console.WriteLine(intList.ElementAt(i));
            }
            else
            {
                Console.WriteLine("Vuot qua");
            }
            if (i < intList.Count())
            {
                Console.WriteLine(strList.ElementAt(i));
            }
            else
            {
                Console.WriteLine("Vuot qua");
            }
            Console.ReadLine();
        }
    }
}