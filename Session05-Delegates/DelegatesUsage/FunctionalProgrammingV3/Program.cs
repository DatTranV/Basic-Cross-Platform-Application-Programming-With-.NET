namespace FunctionalProgrammingV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOnDemand(10, 20, (width, height) =>
            {
                return width * height;
            });
        }
        //Challenge: Viết hàm tính và in ra diện tích hình chữ nhật, style print on demand

        //Những hàm chính mà nhận vào một hàm func F <có tham số> thì khi hàm func F được gọi, ta phải chuẩn bị tham số cho nó thì mới gọi được F, ví dụ F(5) F(10, 10)
        //Tùy hàm F nhận tham số nào
        //Vậy nếu hàm chính cso đầy data riêng thì sao???
        //Ta ko cần chuẩn bị data cho hàm Func F nữa mà 
        //hàm chính chủ động lấy data cho riêng nó đưa cho F
        //Đây chính là nguyên lý bán hàng theo yêu cầu!!
        static void PrintOnDemand(double width, double height, Func<double, double, double> f)
        {
            Console.WriteLine($"Area ({width}, {height} = {f(width, height)})");
            Console.WriteLine("");
        }
    }
}
