namespace ObjectArray
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Gpa}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentArrayV2();
        }
        static void PlayWithStudentArray()
        {
            //toi muon luu ho so 10 sinh vien
            Student s1, s2, s3, s4, s5; //nhiều biến object được khai báo
            int a, b, c, d, e;          //nhiều biến primitive được khai báo
                                        //đều chưa là mảng
            a = 5; b = 6; c = 10;
            s1 = new Student() { Id = "SE1", Name = "An nguyen" };
            s2 = new Student();
            s3 = new Student();
            s4 = new Student();
            s5 = new Student();
            //10 vùng ram cho biến object
            //nhưng chỉ 5 cho biến primitive

            //s1.Name
            //a. là vô nghĩa, vì a đang 5 rồi, biến primitive không chấm gì cả
            //s1. xổ vô số vì là biến object trỏ vùng new có nhiều info

            int[] arr = { 5, 10, 15, a, b, c };
            //    int arr[0] = 5
            //    int arr[3] = a = 5;
            Student[] arrS = new Student[5];
            //vietsub: có 5 biến sinh viên mang tên là: arrS[0], arrS[1], arrS[2]...
            //gán value ra sao?
            arrS[0] = new Student(); //~ s1 = new Student()
            arrS[1] = new Student() { Id = "SE2", Name = "Binh Le" };
            arrS[2] = new Student() { Id = "SE3", Name = "Cuong Vo" };
            arrS[3] = s1;
            Console.WriteLine(arrS[3]);
            arrS[4] = arrS[1];
            Console.WriteLine(arrS[4]);
            arrS[4].Name = "Ngoc Trinh";
            Console.WriteLine(arrS[1]);
            //4 đổi, mà 1 bị đổi theo, 2 thằng cùng trỏ 1 vùng new

            //Mảng ổn không
            Student[] studentList = { s1, s2, s3, s4, s5 };
            //                        [0]
            Console.WriteLine(studentList[0]); //An Nguyen, trỏ cùng
            //mảng object là mảng con trỏ
            //3 tầng ram: tầng tên biến con trỏ mảng
            //          tầng các biến mảng [i] (con trỏ khác)
            //                  vùng new() ứng với con trỏ [i]
            //arr -> []   []  []  []  []
            //       new new new new new
            //mảng primitive, biến con trỏ mảng chấm và hết 
            //mảng object, biến con trỏ mảng chấm và chưa hết .length [i]. chấm ra bên trong vùng new
            //mảng object là mảng các biến object, thì [i] chấm phải vào vùng new object
            //mảng object 2 tầng chấm
        }
        static void PlayWithStudentArrayV2()
        {
            Student[] arr = new Student[30];
            //30 BIẾN STUDENT SẴN SÀNG TRỎ VÀO VÙNG NEW STUDENT()
            //30 GHẾ TRONG PHÒNG HỌC, SẴN SÀNG CHỜ 1 SV CỤ THỂ
            arr[0] = new Student() { Id = "1", Name = "An" };
            arr[1] = new Student() { Id = "2", Name = "Binh" };
            arr[2] = new Student() { Id = "3", Name = "Cuong" };
            arr[3] = new Student() { Id = "4", Name = "Duong" };

            // IN MẢNG
            Console.WriteLine("The student list");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Name);
            }

            //Khi chơi với mảng object, cấm for hết nếu mảng chưa gán hết value, vì phần chưa gán hết là con trỏ null
            //[i] trỏ null, trỏ null mà chấm thì toang!!!
            //Chỉ được for đến chỗ nào vừa gán xong
            //Vậy khi chơi với mảng nói chung, mảng objet nói riêng ta nên có 1 biến count để lưu xem mảng đã gán đầy đến đâu rồi, thì for đến count
            //Bài trên for <4; mảng có n phần tử thì for < N (đếm từ 0)
            //Chơi với mảng primitive, mảng object ko for hết dùng for each, vì for each nó cũng chạy hết mảng luôn!!

            //Chỉ dùng for length, for each khi mảng đã đầy!!
            //Tốt nhất for đến count, cứ thêm 1 value vào mảng thì count++

        }
    }
}
