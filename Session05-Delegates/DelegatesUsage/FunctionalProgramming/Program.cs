namespace FunctionalProgramming
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Action f = SayHello; //[2] gán luật sư thân chủ
        //    //gán value cho biến - biến là hàm
        //    //[3] gọi hàm
        //    f();

        //    //gọi hàm bằng kiểu lập trình hàm

        //}
        static void Main(string[] args)
        {
            //PrintOnDemand(SayHello); //hàm truyền vào hàm

            //Challenge: hãy nhờ PrintOnDemand() in giúp các số chẵn từ 1...100
            //PrintOnDemand(() =>
            //{
            //    Console.WriteLine("The even list from 1 to 100");
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        if (i % 2 == 0)
            //            Console.Write(i + " ");
            //    }
            //});

            //challenge: hãy nhờ PrintOnDemand() in ra tổng các số từ 1..10 
            //và in luôn tổng số chẵn từ 1..10
            //và in luôn tổng số lẽ từ 1..10

            PrintOnDemand(() =>
            {
                Console.WriteLine("List sum on demand is:");
                int sumAll = 0;
                int sumOdd = 0;
                int sumEven = 0;

                for (int i = 1; i <= 10; i++)
                {
                    sumAll += i;
                    if (i % 2 == 0) sumEven += i;
                    else sumOdd += i;
                }
                Console.WriteLine($"Sum all : {sumAll}");
                Console.WriteLine($"Sum even : {sumEven}");
                Console.WriteLine($"Sum odd : {sumOdd}");
            });

        }

        //DI: Tui (hàm chính) sẽ làm mọi điều bạn đưa vào - hàm lambda, delegate đưa vào

        //Hàm đưa vào hàm, đưa logic xử lí bên ngoài vào trong hàm chính

        //          hàm chính       hàm chích vào/inject
        static void PrintOnDemand(Action f) // f = SayHello khi gọi hàm/xài hàm PrintOnDemand(1 hàm khác cụ thể đưa vào || biến cần value)
                                            //f = () => { ... }
        {
            //hàm chính muốn làm gì thì làm, và nếu xài f thì là gọi f()
            //gọi f() tức là gọi 1 hàm gì đó đưa vào!!! DEPENDENCY INJECTION
            Console.WriteLine("Print On Demand itself logic...");
            Console.WriteLine("The list of prime numbers form 1 to 30");
            Console.WriteLine("2 3 5 7 11 13 17 19 23 29...");
            //đúng chuẩn phải for, if chia hết tính toán ra đống số nguyên tố

            Console.WriteLine("Injection section from now on...");
            f.Invoke(); //chả biết f() chạy ra cái gì vì tùy thuộc f đc truyền vào là gì???
        }

        //[1] tạo hàm lẻ
        //static void PrintEvenNumberFrom1To100()
        //{
        //    for (int i = 1; i <= 100; i++)
        //        Console.Write(i + " ");
        //}

        static void SayHello() //hàm này chỉ đơn giản in ra 1 chuỗi
        {
            Console.WriteLine("Welcome to Functional Programming");
        }

        //Viết hàm nhận vào 1 con số nguyên N > 0. Hãy in ra các số chẵn từ 1 đến N
        //Đây là hàm truyền thống: Nhận đầu vào là các giá trị 5 10 15 20 value - type, primitive
        //                         Hoặc nhận vào các object - vùng new, ví dụ (Student s) thì s = new nào đó khi xài
        //Với hàm truyền thống thì chỉ là
        //- Tạo hàm như bên dưới
        //- Gọi hàm truyền value vào qua tham số, ví dụ
        //                  Print1ToN(100)

        //Nếu ta biến đổi hàm truyền thống thành: thay vì nhận đầu vào là 1 primitive hay object, ta nhận vào 1 delegate, 1 hàm lambda thì sao?

        //Vì hàm delegate vẫn thỏa công thức
        //Data - type Biến = Value
        //int           n  = 100;
        //Action        f  = () => { ... };

        //hàm đó dùng qua delegate/lambda được truyên vào 1 hàm khác - hàm chính
        //Khiến cho logic của hàm chính là thay đổi khó lường!!!
        //hàm chính ngoài việc xử lí của riêng nó, nếu nó có invoke hàm delegate đưa vào qua tham số, thì logic hàm chính gồm 2 thứ:
        //- code của riêng hàm chính
        //- code của delegate đưa vào
        //=> khiến hàm chính trở thành cực kì linh hoạt, ai muốn làm gì, đưa logic vào nó sẽ gọi cho
        //khiến cho 1 hàm gốc hàm chính làm đc nhiều việc mà ko biết chính xác sẽ làm gì, tùy tương lại đưa vào là gì, hàm chơi với tương lai
        //Do on demand - làm theo đặt hàng

        //- Dùng để làm gì? để chừa chỗ cho những xử lí sẽ có trong tương lai
        //- Lập trình event của các nút bấm, các GUI element trên trang web, trên destop app
        //Nút bấm button sẽ có 1 hàm On_Click ( chờ nhận vào 1 hàm khác của chúng ta đưa cho nó)
        //User click nút bấm, hàm On_Click() chạy, trong hàm On_Click() chạy thì gọi hàm mình đưa vào
        //Nút bấm phục vụ đc mọi dev trên thế giới này
        static void PrintEvenNumberFrom1ToN(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("The number must be > 0");
                return;
            }
            Console.WriteLine("The list of number is: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
