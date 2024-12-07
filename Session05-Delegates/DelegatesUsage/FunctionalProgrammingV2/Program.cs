namespace FunctionalProgrammingV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOnDemand(x =>
            {
                if (x < 1)
                {
                    Console.WriteLine("The number must be > 0. Try Again!");
                    return;
                }
                Console.WriteLine("The list numbers: ");
                for (int i = 1; i <= x; i++)
                    Console.Write(i + " ");
            }, 50);
        }

        //Viết hàm nhận vào 1 con số N > 0, In ra các số từ 1 đến N
        //Áp dụng style PrintOnDemand()

        //f = x => {...}
        static void PrintOnDemand(Action<int> f, int n)
        {
            Console.WriteLine("This message comes from the method itself");
            Console.WriteLine("From now on... is the delegate/injection section");
            f(n);
        }
    }
}
