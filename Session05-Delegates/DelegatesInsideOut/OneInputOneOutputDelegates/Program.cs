namespace OneInputOneOutputDelegates
{
    public delegate int OneInputOneOutput(int n);
    public delegate bool OneInputOneOutputBoolean(int n);
    public delegate int F(int x, int y);
    internal class Program
    {
        //Viết hàm nhận vào 1 con số nguyên (> 0) trả về bình phương của nó
        //Viết bắt đầu từ hàm lẻ, delegate, anonymous, lambda

        //Viết hàm nhận vào một con số trả về true nếu nó chẵn, trả về flase nếu nó lẻ 
        static void Main(string[] args)
        {
            OneInputOneOutput fPower = PowerByTwo;
            Console.WriteLine(fPower.Invoke(5));

            fPower = delegate (int n) { return n * n; };
            Console.WriteLine(fPower.Invoke(6));


            OneInputOneOutput fPowerLambda = n => n * n;
            Console.WriteLine(fPowerLambda(9));

            OneInputOneOutputBoolean f = IsEven;
            Console.WriteLine(f.Invoke(3));


            // f = n =>
            //{
            //    if (n % 2 != 0) return false;
            //    return true;
            //};
            // Console.WriteLine(f(4));

            f = n => n % 2 == 0;

            Console.WriteLine("Check var: " + f(6368));
            Console.WriteLine("Check var: " + f(3979));

            //Đố em vietsub hàm này: nhận vào n, ko care nó là gì, cứ nhắm mắt return true
            f = n => true;

            //vietsub:
            F fl = (x, y) => 6368;
        }
        static int PowerByTwo(int n) => n * n;

        static bool IsEven(int n) => n % 2 == 0;

        //vì phép so sánh là true
        //return trực tiếp phép só sánh được true false luôn

        //static bool IsEven(int n)
        //{
        //    if (n % 2 != 0) return false;
        //    return true;
        //}

    }
}
