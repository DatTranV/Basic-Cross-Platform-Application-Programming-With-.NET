namespace MusicCollection
//namespace ~ package bên java
//là tên gọi cho cái thư mục chứa tập tin source code này
//1 tập tin source phải nằm ở thư mục nào đó
//giống như 1 cá nhân/ con người phải có nơi sinh nào đó, hộ khẩu nào đó
//trong java gọi là package, c# gọi là namespace
//java: java.util
//      java.lang
//      java.sql
//      javax
//C#:   Java.Util
//      Microsoft.
//      MusicCollection.
//Java: import java.util.*;
//C#:   using MusicCollection;
//
{
    public class Student
    {
        //trong class sẽ chứa gì??
        //khai báo biến và hàm
        //khai báo field và method (nói theo style OOP)
        //class chưa đặc tính và hành vi của những object mà class đại diện
        //sv nào cũng có tên, mã số, địa chỉ, điểm trung bình...
        //biến và hàm => được gọi là members of a class
        //biến hàm khai báo trong class
        int yob = 2004;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //học thêm kĩ thuật khác liên quan đến chuỗi
            //hãy in ra năm sinh và tuổi hiện nay của bạn, dùng biến để lưu trữ tính toán
            int yob = 2004;
            int age = 2024 - yob;
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your yob and age are {0}, {1}", yob, age); //kĩ thuật điền vào chỗ trống để điền value của biến tương ứng, thứ tự biến tính từ 0, 1, 2
            //gọi là place holder
            Console.WriteLine($"Your yob is {yob} and your age is {age}");
            Console.WriteLine($"Your yob is {yob} and your age is {2024 - yob}");
            //kĩ thuật chừa sẵn chỗ trong chuỗi, để biến ở đó để thay value vào
            //kĩ thuật suy luận xem trong chuỗi chỗ nào là biến thì thay value vào
            //nội suy ra chỗ nào là biến trong 1 chuỗi
            //interpolation
            string msg = @$"Your age is {age}\n\n";
            Console.WriteLine(msg);


        }
        //        static void Main(string[] args) //svm tab
        //        {
        //            string lyric = @"Mát lành như dòng suối
        //Tâm hồn mới chớm đôi mươi
        //Vô tư nơi rừng núi, chưa từng ghé chốn xa xôi
        //Vào một ngày nắng xanh, lảng tránh nhân duyên sắp đặt
        //Để rồi mình đi về phía chân đồi
        //";
        //            Console.WriteLine(lyric);
        //            //Khi nao dung verbatim?
        //            //Khi trong chuỗi kí tự có dùng đến những kí tự mà kí tự này lỡ được dùng trong những tình huống đặc biệt, nhưng nay ta muốn in nó ra như bình thường chứ không phải in theo kiểu đặc biệt
        //            //ví dụ đường dẫn tên thư mục và tên tập tin có dấu \ mà dấu \ lỡ được dành cho kí tự đặc biệt 
        //            //vậy nay muốn in dấu \ theo kiểu bình thường thì ta cần nhờ đến verbatim
        //            string path1 = "c:\news\tin-tuc-cong-nghe";
        //            string path3 = "c:\\news\\tin-tuc-cong-nghe";

        //            string path2 = @"c:\news\tin-tuc-cong-nghe";

        //            Console.WriteLine(path1);
        //            Console.WriteLine(path2);
        //            Console.WriteLine(path3);
        //            //verbatim còn dùng khi lưu tên server trong chuỗi connection string kết nối cơ sở dữ liệu
        //            //  MyPC\SQLSERVER  SAI do máy hiểu là \s, chứ ko hiểu nguyên chuỗi
        //            //  MyPC\\SQLSERVER Đúng
        //            // @"MyPC\SQLSERVER"
        //        }


        //code here!!!
        //        static void Main(string[] args)
        //        {
        //            //code here!!!
        //            Console.WriteLine("Mát lành như dòng suối\n\t\tTâm hồn mới chớm đôi mươi\nVô tư nơi rừng núi, chưa từng ghé chốn xa xôi\nVào một ngày nắng xanh, lảng tránh nhân duyên sắp đặt\nĐể rồi mình đi về phía chân đồi");
        //            //kí tự dấu \ là kí tự đặc biệt, nó được dành để
        //            //ghép với vài kí tự khác, ví dụ \n \t để biểu diễn những kí tự đặc biệt, kí tự vô hình với mắt người nhưng lại mang ý nghĩa về mặt trình bày layout

        //            Console.WriteLine(@" \n  \t
        //Mát lành như dòng suối
        //Tâm hồn mới chớm đôi mươi
        //Vô tư nơi rừng núi, chưa từng ghé chốn xa xôi
        //Vào một ngày nắng xanh, lảng tránh nhân duyên sắp đặt
        //Để rồi mình đi về phía chân đồi"); //cw tab
        //            //chữ @ đứng trước cái chuỗi bất kì sẽ biến đổi cái chuỗi trong dấu @ thành chuỗi nguyên bản -raw string
        //            //có sao in vậy, trong chuỗi có gì layout ra sap, in y chang vậy
        //            //kể cả trong chuỗi có \n \t thì phế võ công \ ko còn là ký tự đặc biệt nữa, có \n thì in \n, ko in xuống hàng 
        //            //chuỗi theo style có sao in vậy được gọi là verbatim string
        //        }
        //code here!!!

    }
}
