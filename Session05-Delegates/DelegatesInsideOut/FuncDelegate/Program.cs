namespace FuncDelegate
{
    //Viết hàm tính tổng của các số từ 1 - 100, trả về, ko in trong hàm
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int> fSum = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                    sum += i;

                return sum;
            };
            Console.WriteLine("The result is: " + fSum());

            //Viết hàm tính diện tích hình chữ nhật

            Func<double, double, double> fRectangle = (width, height) =>
            //{
            //    double result = width * height;
            //    return result;
            //};
            width * height;

            Console.WriteLine("The area of rectangle is: " + fRectangle(3.9, 4.8));

            //Viết hàm nhận vào 1 con số, check xem nó có chẵn hay ko
            Func<int, bool> fCheckEven = n => n % 2 == 0;
            Console.WriteLine("The number 200 is even? " + fCheckEven(200));

        }
    }
}
