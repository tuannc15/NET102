using Data;

namespace Demo626
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> MS = DuLieu.dataSource3.Distinct();
            var QS = (from num in DuLieu.dataSource3 select num).Distinct();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}