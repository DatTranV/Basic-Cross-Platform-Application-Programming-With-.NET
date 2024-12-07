using StudentTester.Entities;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateObjectsV2();
        }
        static void CreateObjectsV2()
        {
            Student dung = new Student(yob: 2005, gpa: 8.6, id: "SE1", name: "Dung");
            //Hỏi từng thông tin riêng lẻ của object (class đã đổ info vào)
            Console.WriteLine($"Dũng's YOB: {dung.GetYob()}");
            Console.WriteLine($"Dũng's NAME: {dung.GetName()}");
            Console.WriteLine($"Dung's FULL: {dung.ToString()}");
            Console.WriteLine($"Dung's FULL: {dung}");
            //Nếu một class không có hàm ToString() tường minh - tự tạo ToString() - Explicit
            //Thì khi ta gọi ToString() hay cw(biến-object) thì mặc định hàm ToString() của class ông tổ - class object sẽ được gọi, hàm cha chạy thay cho con
            //Cha nói rằng mày là student - trả về tên class mà object thuộc về
            //Bên java thì ko trả về tên class của object mà trả về chuỗi số hexa đại diện cho data được đổ vào - mã hash - mã băm
        }

        static void CreateObject()
        {
            //lôi cái khuôn, lấy cái phễu đổ vật liệu vào đúc 1 object
            //lôi cái form/biểu mẫu, lấy cây bút, viết chữ lên form
            //ta được 1 bức tượng, 1 tờ giấy đã điền info => object
            //ta sẽ đặt tên cho object cho dễ gọi -> biến object
            //biến object chính là nickname của 1 object 
            Student an = new Student("SE1", "An Nguyen", 2004, 8.6);


            an.FlexProfile(); //gọi hành động của object, giao tiếp với object

            Student binh = new("SE2", "Binh Le", 2004, 8.7);
            binh.FlexProfile();

            var cuong = new Student("SE3", "Cuong Vo", 2004, 8.8);
            cuong.FlexProfile();
            //Var là kĩ thuật khai báo biến mà ko thèm chỉ ra data type trước 
            //Khi runtime, rumtime sẽ tự suy data type dựa trên value được gán bên tay phải
            //Var: Type Infference - suy luận kiểu - giống js
            //                          Java có luôn
            Student dung = new Student(yob: 2005, gpa: 8.6, id: "SE1", name: "Dung");
            //Kĩ thuật gọi hàm đưa tham số không theo thứ tự như đề xuất của hàm, kĩ thuật này gọi là named argument 
            //Đưa value vào hàm chỉ định luôn value map với tham số nào. Giúp linh hoạt thứ tự truyền tham số và dễ đọc code, value đi kèm tên biến

        }
    }
}
