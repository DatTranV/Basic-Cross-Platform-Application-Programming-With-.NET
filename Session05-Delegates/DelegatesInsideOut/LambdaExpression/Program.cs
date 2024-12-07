namespace LambdaExpression
{
    //Challenge: Viết hàm in ra các số lẻ từ 1...100
    //dùng hàm lẻ, gọi trực tiếp hàm
    //dùng hàm lẻ, gọi qua delegate
    //dùng anonymous function
    //      ->biến đổi anonymous function thành lambda expression (anonymous function rút gọn thì thành lambda expression - tối giản phân số 5/10)
    public delegate void NoIntNoOut();     //public class NoInNoOut {..nhận vào tên hàm Invoke()}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call method directly: ");
            PrintOddFrom1To100();

            NoIntNoOut f;
            f = PrintOddFrom1To100;
            Console.WriteLine();
            Console.WriteLine("Call method indirectly: ");
            f.Invoke();

            f = delegate ()
            {
                Console.WriteLine("Odd list: ");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            };
            Console.WriteLine();
            Console.WriteLine("Call method anonymous: ");
            f();

            //Rút gọn anonymous 
            f = () =>
            {
                Console.WriteLine("The list of numbers divided by 5: ");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            };
            Console.WriteLine();
            Console.WriteLine("Call method by LAMBDA expression: ");
            f();

            //Challenge tiếp theo: Viết hàm tính tổng các số chẵn từ 1..10
            NoIntNoOut fsum = () =>
            {
                Console.WriteLine();
                Console.WriteLine("Total of even numbers from 1 to 10: ");
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Total: {sum}");
            };
            fsum();
        }
        static void PrintOddFrom1To100()
        {
            Console.WriteLine("Odd list: ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");

                }

            }
        }
    }
}
