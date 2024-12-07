namespace AnonymousFunction
{
    //Challenge: viết 2 hàm kiểu ko vào ko ra, in ra câu gì đó, sau đó chơi trò luật sư thân chủ

    public delegate void NoInputNoOutput();
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutput f1;
            f1 = Hello;
            f1 += GoodBye;
            f1();
            f1.Invoke(); //cách gọi thứ 2, lôi cổ cái hàm 
            //~~~~~~ an.GetName()   an.ToString()

            //Tôi muốn in ra các số từ 1 đến 100
            f1 = PrintIntegerList;
            f1.Invoke();

            f1 = delegate ()    //anonymous function: hàm ko có tên, bán tên cho luật sư rồi
            {
                Console.WriteLine("The list of even numbers: ");
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i}");
                        Console.WriteLine();
                    }
                }
            };
            f1();

            //Challenge: Viết hàm in ra tổng các số từ 1...1000
            //1 hàm lẻ bình thường học từ xưa đến nay -> có 1 tên hàm gốc, cúng cơm
            //ví dụ void PrintMessage()

            //Khi học delegate, thì 1 hàm có 2 tên, tên gốc và tên luật sư
            //NoInputNoOutput f1 = PrintMessage() //hàm gốc PrintMessage nickname là f1

            //Dẹp tên gốc, chỉ còn nickname, bị dụ bán mất cái tên cho luật sư
            //Hàm gốc mất tên, gọi là hàm vô danh anonymous

            f1 = delegate ()
            {
                int sum = 0;
                Console.WriteLine("The total of list from 1 to 100:");
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Total: {sum}");
            };
            f1.Invoke();
        }
        static void Hello()
        {
            Console.WriteLine("Hello EveryOne");
        }
        static void GoodBye()
        {
            Console.WriteLine("Bye! See you again.");
        }
        static void PrintIntegerList()
        {
            Console.WriteLine("The list of numbers: ");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"{i}");
                Console.WriteLine();
                //lệnh for in xong dãy số ko xuống hàng, mình phải làm thêm lệnh này
            }

        }
    }
}
