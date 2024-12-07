namespace OneInputNoOutputDelegates
{
    //viết hàm in ra các số từ 1 đến n (n >= 1)
    //xài hàm lẻ truyền thống 
    //xài delegate
    //xài anonymous, lambda
    public delegate void OneInputNoOutputDelegate(int n);
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumberFrom1ToN(0);
            OneInputNoOutputDelegate f;
            f = PrintNumberFrom1ToN;
            Console.WriteLine();
            f.Invoke(50);

            //anonymous
            f = delegate (int n)
            {
                if (n < 1)
                {
                    Console.WriteLine("The numbers can not be lower than 1");
                    return;
                }

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                }
            };
            Console.WriteLine();
            f(5);

            //lambda: In số lẻ từ 1 đến n  Version 1: Ăn bớt delegate, và thêm =>
            OneInputNoOutputDelegate flambda = (int n) =>
            {
                if (n < 1)
                {
                    Console.WriteLine("The numbers can not be lower than 1");
                    return;
                }

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
            };
            Console.WriteLine();
            Console.WriteLine("Lambda version 1: ");
            flambda(20);

            //lambda: In số lẻ từ 1 đến n  Version 2: Bỏ data type ở tham số
            OneInputNoOutputDelegate flambdav2 = (n) =>
            {
                if (n < 1)
                {
                    Console.WriteLine("The numbers can not be lower than 1");
                    return;
                }

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
            };
            Console.WriteLine();
            Console.WriteLine("Lambda version 2: ");
            flambdav2(30);

            //lambda: In số lẻ từ 1 đến n  Version 3: Bỏ dấu ngoặc luôn
            OneInputNoOutputDelegate flambdav3 = n =>
            {
                if (n < 1)
                {
                    Console.WriteLine("The numbers can not be lower than 1");
                    return;
                }

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
            };
            Console.WriteLine();
            Console.WriteLine("Lambda version 3: ");
            flambdav3(40);
        }
        static void PrintNumberFrom1ToN(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("The numbers can not be lower than 1");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
