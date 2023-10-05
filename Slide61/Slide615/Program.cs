namespace Slide615
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] objList = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] objVal = { };
            int result = (from x in objList select 1).LastOrDefault();
            int val = (from x in objVal select 1).LastOrDefault();
            Console.WriteLine(result);
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }
}