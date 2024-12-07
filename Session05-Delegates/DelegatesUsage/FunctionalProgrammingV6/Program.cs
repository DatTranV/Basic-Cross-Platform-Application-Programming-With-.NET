namespace FunctionalProgrammingV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge: Hãy trả ra list con số nguyên thỏa điều kiện nào đó
            //          1:  Trả ra tất cả mảng
            //          2:  Trả ra số >= 1000
            //          3:  Trả ra tất cả số chẵn
            List<int> r1 = GetDataOnDemand(x => true);
            Console.WriteLine("All of data");
            foreach (var x in r1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            List<int> r2 = GetDataOnDemand(x => x >= 1000);
            foreach (var x in r2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            List<int> r3 = GetDataOnDemand(x => x % 2 == 0);
            foreach (var x in r3)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

        }

        static List<int> GetDataOnDemand(Predicate<int> f)
        {
            int[] arr = { 5, 10, 15, 20, -100, -1, -2, 16, 63, 68, 39, 79, 101, 333, 555, 6789, 2204, 6868, 6368, 6969 };

            List<int> result = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (f(arr[i]))
                    result.Add(arr[i]);
            }
            return result;
        }
    }
}
