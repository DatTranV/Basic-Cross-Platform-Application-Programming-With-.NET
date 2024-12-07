namespace ActionDelegate
{
    //challengeL viết hàm in ra các số từ 1..100
    internal class Program
    {
        static void Main(string[] args)
        {
            Action f = () =>
            {
                for (int i = 1; i <= 100; i++)
                    Console.Write(i + " ");
            };
            f();
        }
    }
}
