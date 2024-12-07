using StudentManagement.Services;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSE = new Cabinet(); //trong ram có 1 vùng new bự
            //vùng new này có sẵn 1 cái mảng 30 student chờ add từng phần tử
            //và biến count đang bằng 0
            tuSE.AddStudent("SE1", "An Nguyen", 2004, 8.6); //[0] = new() count++ là 1
            tuSE.AddStudent("SE2", "Binh Le", 2004, 8.7); //[1] = new() count++ là 2
            tuSE.AddStudent("SE3", "Cuong Vo", 2004, 8.8); //[2] = new() count++ là 3
            tuSE.AddStudent("SE4", "Dung Pham", 2004, 8.9); //[3] = new() count++ là 4

            tuSE.PrintStudentList();

            //vì thiết kế kiểu OOP, nên nếu ta muốn lưu hồ sv ngành biz, thì new Cabinet() thôi
            Console.WriteLine("Biz cabinet");
            Cabinet tuBiz = new Cabinet();
            tuBiz.AddStudent("SS1", "An Nguyen", 2005, 8.8);
            tuBiz.PrintStudentList();

        }
    }
}
