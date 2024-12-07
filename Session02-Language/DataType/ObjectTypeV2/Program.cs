using ObjectType;

namespace ObjectTypeV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student() { Id = "SE1", Name = "An Nguyen" };
            Student binh = new Student() { Id = "SE2", Name = "Binh Le", Yob = 2004, Gpa = 8.7 };
            int yob = 2004; Console.WriteLine("Hello, World!");

            an = binh; // vùng new an nguyen, se1 bị mồ côi, sẽ bị dọn dẹp do ko ai trỏ nữa
            an = null;
            Student cuong = binh; //cuong trỏ cùng vùng new binh đang trỏ
            binh = null;

        }
    }
}
//object = null; java và C# đều có, mang ý nghĩa: biến đang ko tham chiếu đến 1 object
//object chưa xác định, từ từ gán sau, trỏ vùng new sau