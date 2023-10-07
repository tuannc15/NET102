using Data;

namespace Demo625
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IEnumerable<int> MS = DuLieu.dataSource1.Intersect(DuLieu.dataSource2);
            var QS = (from num in DuLieu.dataSource1 select num)
                .Intersect(DuLieu.dataSource2).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
