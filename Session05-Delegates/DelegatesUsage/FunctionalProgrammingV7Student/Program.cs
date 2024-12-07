namespace FunctionalProgrammingV7Student
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
            Console.WriteLine("Get All Student: ");
            List<Student> r0 = GetStudentByFilter(x => true);
            foreach (var x in r0)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();

            List<Student> r1 = GetStudentByFilter(x => x.Gpa >= 8);
            foreach (var x in r1)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();

            List<Student> r2 = GetStudentByFilter(x => x.Yob > 2004 && x.Gpa >= 8);
            foreach (var x in r2)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();

            //Xài với action
            //Challenge: In ra tất cả sinh viên
            //                                  có điểm < 5
            Console.WriteLine("All student printed by Action");
            GetStudentByFilter(x => Console.WriteLine(x));
            Console.WriteLine("Students with grade < 5 by Action");
            GetStudentByFilter(x =>
            {
                if (x.Gpa < 5)
                    Console.WriteLine(x);
            });

        }

        //Viết hàm filter danh sách sinh viên theo nhu cầu
        //Ví dụ: lọc ra những sinh viên có điểm trung bình >= 8
        //                                 điểm trung bình < 5
        //                                 Năm sinh >= 2004
        //                                 Năm sinh >= 2004 và Gpa >=8
        //                                 ... vô chừng filter
        //Id, Name, Yob, Gpa, Address, Major, Province, Phone,...


        static List<Student> GetStudentByFilter(Predicate<Student> fCheckVar)
        {
            List<Student> result = new();

            //Ta cần bộ data cái đã
            List<Student> arr = [new Student() {Id = "SE1", Name = "An Nguyen" , Yob = 2004, Gpa = 8.6 },
                new Student() {Id = "SE2", Name = "Binh Le" , Yob = 2004, Gpa = 8.7 },
                new Student() {Id = "SE3", Name = "Cuong Vo" , Yob = 2000, Gpa = 8.8 },
                new Student() {Id = "SE4", Name = "Dung Pham" , Yob = 2004, Gpa = 4.4 },
                new Student() {Id = "SE5", Name = "Em Tran" , Yob = 2001, Gpa = 4.9 },
                new Student() {Id = "SE6", Name = "Giang Ly", Yob = 2001, Gpa = 5.0 }
            ];
            //arr.Add(new Student() {});
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (fCheckVar(arr[i]))
            //        result.Add(arr[i]);
            //}
            foreach (var x in arr)
            {
                if (fCheckVar(x))
                    result.Add(x);
            }
            return result;
        }
        static void GetStudentByFilter(Action<Student> f)
        {

            //Ta cần bộ data cái đã
            List<Student> arr = [new Student() {Id = "SE1", Name = "An Nguyen" , Yob = 2004, Gpa = 8.6 },
                new Student() {Id = "SE2", Name = "Binh Le" , Yob = 2004, Gpa = 8.7 },
                new Student() {Id = "SE3", Name = "Cuong Vo" , Yob = 2000, Gpa = 8.8 },
                new Student() {Id = "SE4", Name = "Dung Pham" , Yob = 2004, Gpa = 4.4 },
                new Student() {Id = "SE5", Name = "Em Tran" , Yob = 2001, Gpa = 4.9 },
                new Student() {Id = "SE6", Name = "Giang Ly", Yob = 2001, Gpa = 5.0 }
            ];
            //arr.Add(new Student() {});
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (fCheckVar(arr[i]))
            //        result.Add(arr[i]);
            //}
            foreach (var x in arr)
            {
                f(x);
            }

        }
    }
}
