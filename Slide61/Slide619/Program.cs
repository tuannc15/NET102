using Data;

namespace Slide619
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result1 = Dulieu.list1.DefaultIfEmpty();
            var result2 = Dulieu.list2.DefaultIfEmpty();

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}