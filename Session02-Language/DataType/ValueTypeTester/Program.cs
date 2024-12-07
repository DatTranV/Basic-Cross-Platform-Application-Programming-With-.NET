namespace ValueTypeTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void PlayWithIntegers()
        {
            int yob = 2004; //2004 là 1 con số nguyên - int
            //int là từ khóa biểu diễn cho những đại lượng đơn giản (2004 và hết rồi), con số nguyên (không có phần lẻ)
            //int: còn gọi là data type ~ hình thái dữ liệu, hình thái info, cách biểu diễn thông tin
            //int: 1 dạng biểu diễn thông tin là những con số nguyên không phần lẻ

            double pi = 3.14, vat = 0.08;
            //double: data type đại diện cho đám số thực, có phần lẻ
            //int, long, float, double, char,.. => kiểu dữ liệu đơn giản
            //kiểu dữ liệu nguyên thủy ~ primitive data type (java) 
            //kiểu dữ liệu thuần giá trị (chỉ mang value thuần) ~ value type (C#)
            //nó chỉ tốn đúng 1 vùng ram để lưu giá trị
            //int -> 1 vùng ram 4 BYTE
            //long -> 1 vùng ram 8 BYTE
            //float -> 1 vùng ram 4 BYTE 
            //char -> 1 vùng ram 2 BYTE

            //với biến primitive thì tên biến là value luôn rồi, lấy tên biến xài luôn, vì nó là value
            Console.WriteLine(yob); //yob đại diện cho 1 vùng ram, tên gọi 1 vùng ram, chứa value sẵn dùng luôn
            Console.WriteLine("yob: "+yob);
            int a = 10; //có 1 vùng ram 4 byte tên là a, chứa value 10

            a = yob; //vietsub: yob cho a cái value nó đang có 
            //2 biến = nhau, nghĩa là lấy value của bên phải đổ bên trái, cho nhau value, mỗi thằng vẫn 1 vùng ram
            Console.WriteLine("a after: " +a);
            yob = 2005; //thay đổi yob
            Console.WriteLine("yob again: "+yob); //2005
            Console.WriteLine("a again: " +a); //2004

            //biến primitive, thằng nào biết nhà thằng nấy! Vì riêng vùng ram 
            //value chứa thằng trong vùng ram!!

            
        }
    }
}
