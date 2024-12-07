namespace ObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student() { Id = "SE1", Name = "An Nguyen" };
            Student binh = new Student() { Id = "SE2", Name = "Binh Le", Yob = 2004, Gpa = 8.7 };
            int yob = 2004; //4 byte trong ram, 1 vùng ram

            //Biến object tốn 2 vùng ram
            //1 vùng ram cho vùng new lớn chưa các info được đổ vào: id, name, yob, gpa..
            //1 vùng ram biến con trỏ, lưu tọa độ vùng new
            //an: 1 vùng ram con trỏ, chờ trỏ tọa độ vùng new bự
            //new Student() { Id = "SE1", Name = "An Nguyen" } : value bự, value gồm nhiều info nằm riêng ở vùng ram riêng
            //Muốn sờ chạm vùng new, dùng dấu chấm qua biến con trỏ

            //biến value type, primitive, ko có chấm
            //biến object có chấm để vào vùng new bự để lấy thông tin

            //2 biến cùng kiểu có quyền cho nhau value 
            int a = 5, b = a;
            Console.WriteLine($"An: {an.Id} | {an.Name} | {an.Yob} | {an.Gpa}");
            Console.WriteLine($"Binh: {binh.Id} | {binh.Name} | {binh.Yob} | {binh.Gpa}");
            an = binh; //binh cho an cai value binh dang co
            Console.WriteLine($"An: {an.Id} | {an.Name} | {an.Yob} | {an.Gpa}");
            Console.WriteLine($"Binh: {binh.Id} | {binh.Name} | {binh.Yob} | {binh.Gpa}");
            //2 biến object bằng nhau tức là trỏ cùng, 2 chàng trỏ chung 1 nàng,
            //chàng này thay đổi (set vùng new), chàng kia thấy theo
            //2 biến primitive = nhau, cùng value, sau đó ai về nhà nấy, t thay đổi value, k ảnh hưởng cậu
            //2 biến object = nhau, cùng value, cùng trỏ 1 chỗ
            //Đứa này thay đổi vùng new, đứa kia bị ảnh hưởng theo!!

            an = null; //lưu số 0, an sẽ trỏ vào đáy ram nơi ko có object Student
            //Biến object ko trỏ object nào cả 
            Console.WriteLine(binh.Name);
            Console.WriteLine(an.Name);
            binh = null;

            //Nếu 1 vùng new ko dc trỏ đến bởi biến nào cả thì vùng new bị mồ côi, lát hồi sẽ có cty môi trường đô thị - garbage collector - 1 class trong runtime tự đi clear vùng new để tiết kiệm ram, dành ram cho lệnh new mới sau này
        }
    }
}
