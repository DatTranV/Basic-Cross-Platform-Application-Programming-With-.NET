namespace ActionGenericDelegates
{
    //Viết hàm nhận vào 1 con số n
    //Và in ra các số tự nhiên từ 1 đến n
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> f = n =>
            {
                for (int i = 0; i <= n; i++)
                    Console.Write(i + " ");
            };
            f(7);

            //Viết hàm tính diện tích hình chữ nhật với hai cạnh bất kì
            Action<double, double> rectangle = (width, height) =>
            Console.WriteLine($"The area of rectangle is : {width * height}");
            Console.WriteLine();
            rectangle(4.3, 5.9);

            //Delegate và từ khóa var
            //var: Type Inferrence: Suy luận kiểu, IDE, Runtime nó sẽ đoán data type là gì trong ngữ cảnh câu lệnh
            var x = 10;
            Console.WriteLine(x);
            //var f4 = delegate (int x) { Console.WriteLine(x); };
            var f4 = (int x) => Console.WriteLine(x);
            //f4 là hàm có 1 đầu vào là con int, ko trả ra, vì có lệnh cw
            //suy ra f4 là Action<int>

            Console.WriteLine("F4:");
            f4(6368);

            //ăn bớt thử; bị chửi vì mất manh mối ko suy được x là loại data type nào; var f5 đang nhờ cậy vế phải, vế phải cx lại mơ hồ!!!
            //var f5 = (x) => Console.WriteLine(x);
            //Ăn bớt nhưng phải để lại manh mối suy luận, mới gán ram được
            //Student s = new Student(); ok
            //Student s = new(); ok
            //var s = new Student(); ok
            //var s = new (); //chửi

            //Challenge: Viết hàm in ra các số từ 1..100 ko được dùng ACTION<> tường minh; nghĩa là phải dùng var
            var fNumber = () =>
            {
                for (int i = 1; i <= 100; i++)
                    Console.Write(i + " ");
            };
            fNumber();




        }
    }
}
