using StudentTesterV5.Entities;

namespace StudentTesterV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateObjectV2();
        }

        static void CreateObjectV2()
        {
            ////Student an = new Student();
            //an.Id = "SE1";
            //an.Name = "An Nguyen";
            //an.Yob = 2004;
            //an.Gpa = 8.6;
            //Student an = new(???, ???, ???); //constructor đổ info vào
            //Student an = new Student() {các hàm set được gọi ở đây};
            Student an = new Student() { Id = "SE1", Name = "An Nguyen", Yob = 2004, Gpa = 8.6 }; //set full
            Student binh = new Student() { Id = "SE2", Name = "Binh Le" }; //set 2

            //Cú pháp tạo mới object dùng hàm set ngay lúc new thì gọi là
            //Object Initialization
            Console.WriteLine("An Info: " + an.Id + an.Name + an.Yob + an.Gpa);
            Console.WriteLine($"Binh Info: {binh.Id} | {binh.Name} | {binh.Yob} | {binh.Gpa}");
        }
        static void CreateObject()
        {
            //Nếu 1 class ko tạo ra constructor, thì ta vẫn new được object, nhưng toàn bộ info bên trong object mang giá trị default
            //Tương đương ngoài đời ta xin một cái form trống về nhà điền vào sau, nó vẫn là cái form của riêng bạn
            //Xin cái form trống ~ photo cái form từ bản gốc, mình điền vào bản photo sau

            //Nếu class không có constructor, ta vẫn tạo được object qua toán tử new, vẫn gọi phễu nhưng không có tham số đưa vào
            //Nếu một class ko có constructor, runtime sẽ tự tạo cho bạn một constructor rỗng, 1 empty constructor, 1 default constructor, 1 constructor ngầm tạo ~ implicit constructor
            //constructor này ko code, ko đầu vào (ko đầu vào tức là không có gì để đổ tham số đưa vào, ko code tức là không đổ vào backing field nào
            //=> mọi backing field mang default
            Student an = new Student(); //xin tờ photo trống id, name, yob, gpa đem về điền sau
            //điền sau tức là chỉnh sửa info từ trống thành có gì đó -> hàm set()
            Console.WriteLine($"An Info: {an.Id} | {an.Name} | {an.Yob} | {an.Gpa}");

            //Chỉnh sửa Info, gọi prop = xxx, thì xx đc chuyển cho backing field cất giữ ~ hàm set() được gọi
            an.Id = "SE1";
            an.Name = "An Nguyen";
            an.Yob = 2004;
            an.Gpa = 8.6;

            Console.WriteLine($"An Info: {an.Id} | {an.Name} | {an.Yob} | {an.Gpa}");

            Student binh = new();
            binh.Id = "SE2";
            binh.Name = "Binh Le";
            binh.Yob = 2004;
            binh.Gpa = 8.7;
            Console.WriteLine($"An Info: {binh.Id} | {binh.Name} | {binh.Yob} | {binh.Gpa}");


        }
    }
}
