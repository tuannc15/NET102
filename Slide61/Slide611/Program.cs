using System.Text;

namespace Slide611
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<String>() { null, "Mot", "Hai", "Ba", "Bon", "Nam" };
            IList<string> emptyList = new List<string>();
            Console.WriteLine("Phần tử đầu tiên của intList: " + intList.First());
            Console.WriteLine("Phần tử đầu tiên chia hết cho 2 của intList: " + intList.First(x => x % 2 == 0));
            Console.WriteLine("Phần tử đầu tiên của strList: " + strList.First());
            try
            {
                Console.WriteLine(emptyList.First());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}