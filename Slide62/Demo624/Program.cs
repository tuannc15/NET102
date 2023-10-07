using System.Text;
using Data;

namespace Demo624
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MS = DuLieu.dataSource1.Union(DuLieu.dataSource2);
            var QS = (from num in DuLieu.dataSource1 select num)
                .Union(DuLieu.dataSource2).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}