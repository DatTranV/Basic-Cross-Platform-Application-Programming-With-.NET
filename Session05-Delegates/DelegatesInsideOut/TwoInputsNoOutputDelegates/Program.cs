namespace TwoInputsNoOutputDelegates
{
    public delegate void TwoInputsNoOutputDelegates(double a, double b);
    internal class Program
    {
        //Viết hàm tính diện tích của hình chữ nhật bất kỳ
        //Viết theo các style: hàm lẻ, delegate, anonymous, lambda
        static void Main(string[] args)
        {
            GetRectangleArea(3, 4);

            TwoInputsNoOutputDelegates rectangle = GetRectangleArea;
            rectangle(4, 5);
            //
            rectangle = delegate (double width, double height)
            {
                Console.WriteLine($"The area of rectangle is : {width * height}");
            };
            rectangle(5, 6);
            //lambda lv1 - bỏ delegate
            rectangle = (double width, double height) =>
            {
                Console.WriteLine($"The area of rectangle is : {width * height}");
            };
            rectangle(7, 8);
            //lambda lv2 - bỏ data type
            rectangle = (width, height) =>
            {
                Console.WriteLine($"The area of rectangle is : {width * height}");
            };
            rectangle(9, 10);
            //lambda lv2 - bỏ ngoặc vì chỉ có 1 lệnh (giống 1 phần expression bodied)
            rectangle = (width, height) =>
            Console.WriteLine($"The area of rectangle is : {width * height}");
            rectangle.Invoke(20, 30);


            TwoInputsNoOutputDelegates fPower = (a, b) => Console.WriteLine($"{a} ^ {b} = " + Math.Pow(a, b));
            fPower(5, 6);
        }
        static void GetRectangleArea(double width, double height) =>
            Console.WriteLine($"The area of rectangle is : {width * height}");

        //Viết tiếp hàm tính số mũ x ^ y và in ra kq. Gợi ý dùng hàm Math.Pow(x, y) cho nhanh

    }
}
