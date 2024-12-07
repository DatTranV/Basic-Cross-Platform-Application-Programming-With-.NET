namespace PrimitiveArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void PlayWithArrayV2()
        {
            double[] rain = new double[365];
            //có 365 biến double đã được tạo ra trong ram, nhưng ở sát nhau 
            //cùng tên là rain
            //vùng ram bự chứa 365 biến double
            //tên mỗi biến ra sao???
            //rain[0], rain[1], rain[2]...rain[364];
            //ta dùng [index từ 0] để phân biệt các biến trong mảng, từng phần tử ~ element trong mảng
        }
        static void PlayWithArrayV1()
        {
            //Tôi muốn lưu lượng mưa trong tuần
            double v1 = 50, v2 = 10, v3 = 20, v4, v5, v6, v7; //không đc gọi là mảng, mà gọi là khai báo lẻ nhiều biến cùng lúc
            //Các biến có thể nằm sát nhau, cx có thể nằm rải rác trong ram
            //Biến cục bộ: Khai báo phải gán value mới xài được
            //Field, Backing Field: Ko gán value, khi new sẽ mang default
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);

            //Dễ hiểu, dễ dùng, đơn giản trong cách sử dụng, cần biến nào khai báo biến đó, gọi tên biến để dùng
            //Vấn đề: ko áp dụng được tốt cho bài toán cần lưu nhiều data
            //Hãy lưu lượng mư trong năm (365 ngày), 10 năm (3650 ngày)
        }
    }
}

//Mảng - Array
//Là kĩ thuật khai báo nhiều biến cùng lúc, cùng kiểu, cùng tên, và ở sát nhau
//Chơi mảng là khai báo số đông các biến
//Có mấy loại biến, dựa theo số vùng ram cần sử dụng:
//có 2 loại biến: biến primitive (value-type)	và biến object
//			tốn 1 vùng ram			tốn 2 vùng ram
//			ko chấm gì cả		  1 vùng con trỏ, chấm xổ vùng new
//mảng primitive tốn mấy vùng ram???
//				2 vùng ram: 1 vùng cho biến con trỏ, 1 vùng cho new
//mảng sinh viên, mảng object, tốn mấy vùng ram
//				3 vùng ram
