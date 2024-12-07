namespace DelegatesFinal
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string ToString() => $"{Id} | {Name} | {Yob} | {Gpa} ";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> arr = [new Student() {Id = "SE1", Name = "An Nguyen" , Yob = 2004, Gpa = 8.6 },
                new Student() {Id = "SE2", Name = "Binh Le" , Yob = 2004, Gpa = 8.7 },
                new Student() {Id = "SE3", Name = "Cuong Vo" , Yob = 1995, Gpa = 8.8 },
                new Student() {Id = "SE4", Name = "Dung Pham" , Yob = 2004, Gpa = 4.4 },
                new Student() {Id = "SE5", Name = "Em Tran" , Yob = 2001, Gpa = 4.9 },
                new Student() {Id = "SE6", Name = "Giang Ly", Yob = 2006, Gpa = 5.0 }
                       ];

            //Trong thiết kế của collections class (List, ArrayList, Map, Set,...) nó chứa 1 danh sách, chứa nhiều object
            //Những class này ngoài việc cung cấp các hàm CRUD data trong nó, thì nó còn cung cấp thêm các hàm filter data, theo điều kiện bên ngoài đưa vào
            //Vì ko biết nhu cầu filter data của mỗi deb là thế nào, tốt nhất nhận vào 1 delegate, tùy hàm mà nó sẽ filter giúp, trả về list khác, hay in ra 1 list, hay để hàm ngoài tự in

            //Challenge: Inra tất cả danh sách SV
            //Dẹp luôn for i, dẹp luôn for each, chơi for each kiểu lambda
            Console.WriteLine("All of students");
            arr.ForEach(x => Console.WriteLine(x));

            //In ra những sv có điểm trung bình < 5
            Console.WriteLine("Students with Gpa < 5");
            arr.ForEach(x =>
            {
                if (x.Gpa < 5) Console.WriteLine(x);
            });

            Console.WriteLine();
            Console.WriteLine("Students with Yob < 2004");
            //lấy ra danh sách sv có năm sinh < 2004
            arr.FindAll(x => x.Yob < 2004).ForEach(x => Console.WriteLine(x));

            //tìm và in ra những sv có năm sinh từ 2000 - 2005
            Console.WriteLine();
            Console.WriteLine("Students with yob from 2000 to 2005");
            arr.FindAll(x => x.Yob >= 2000 && x.Yob <= 2005).ForEach(x => Console.WriteLine(x));
        }
    }
}
