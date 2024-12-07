namespace BasicList
{
    public class Student
    {
        public string Id { get; set; } //đằng sau chính là _id
        public string Name { get; set; }                  //_name
        public override string ToString() => $"STUDENT: {Id} | {Name}";

    }

    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"LECTURER: {Id} | {Name}";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithListV2();
        }
        static void PlayWithListV2()
        {
            var list = new List<Student>();
            List<Student> arr = new List<Student>();
            List<Student> arr1 = new();
            //3 cách khai báo tương đương nhau
            //full 2 bên, cắt trái, cắt phải
            arr.Add(new Student() { Id = "SE1", Name = "An Nguyen" });
            arr.Add(new Student() { Id = "SE2", Name = "Binh Le" });
            arr.Add(new Student() { Id = "SE3", Name = "Cuong Vo" });
            arr.Add(new Student() { Id = "SE4", Name = "Dung Pham" });

            Console.WriteLine("The list of students");
            for (int i = 0; i < arr.Count; i++)
            {
                //Console.WriteLine(arr[i]); gọi thầm ToString() của Student
                Console.WriteLine(arr[i].Name);
            }
            //foreach (Student x in arr)
            foreach (var x in arr)
            {
                //Console.WriteLine(x); gọi thầm ToString() của Student
                Console.WriteLine(x.Name);
            }

            


        }
        static void PlayWithListV1()
        {
            List<int> arrInt = new List<int>();
            arrInt.Add(1);
            arrInt.Add(2);
            //arrInt.Add(3.0); strongly type - mạnh mẽ chặt chẽ trong việc check kiểu đưa vào có đúng cam kết int hay ko
            arrInt.Add(300);
            arrInt.Add(-400);
            //in dùng for hết danh sách oke luôn
            for (int i = 0; i < arrInt.Count; i++)
            {
                Console.WriteLine(arrInt[i]);
            }
            //toán tử với mọi x thuộc tập hợp arrInt
            foreach (var x in arrInt)
            {
                Console.WriteLine(x);
            }
        }
    }
}
