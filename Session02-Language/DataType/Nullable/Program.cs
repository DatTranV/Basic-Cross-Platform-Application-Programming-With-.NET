namespace Nullable
{
    class GradeV1
    {
        private int _id;
        private string _classId;
        private string _studentId;
        private double? _pe;
        private double? _te;

    }
    class GradeV2
    {
        public int Id { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public double? PE { get; set; }
        public double? TE { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeV2 grade1 = new() { Id = 1, ClassId = "SE1801", StudentId = "SE123456", PE = null, TE = null};

            GradeV2 grade2 = new() { Id = 1, ClassId = "SE1801", StudentId = "SE123457" };

            Console.WriteLine($"Grade 1: {grade1.Id} | {grade1.ClassId} | {grade1.StudentId} | {grade1.PE} | {grade1.TE}");

            Console.WriteLine($"Grade 2: {grade2.Id} | {grade2.ClassId} | {grade2.StudentId} | {grade2.PE} | {grade2.TE}");
        }

        //static void Main(string[] args)
        //{
        //    double pe = 5; //oke
        //    //double te = -1; //ko được vì điểm phải từ 0...10
        //    //double te = null; //để nói rằng chưa thi!!!
        //    //bị chửi vì double ko chấp nhận null do nó là value type tức là phải cho con số nào đó

        //    //C# giới thiệu nullable data type. Cho phép biến primitive được mang thêm giá trị null để tương thích DB
        //    double? te = null;
        //    te = 8.0; //oke
        //    //double? chính là double và thêm null, giúp tương thích db
        //    //ta sẽ có int? long? float? char?... để mang null
        //    //Student, Lecturer, Person, Dog, Cat.. -> sẵn sinh ra đc quyền gán null, nên ko cần thiết phải 
        //    //Student?, Lecturer?,...
        //    //Thích thì dùng ? với object data type, ko thích ko sao, vì nó đc mang null bẩm sinh rồi

        //    //Java ko có, nó phải boxing, wrapper
        //    //Biến đổi cái primitive thành object thì mới xài NULL được
        //    //int -> Integer mới dc xài null (biến object)
        //    //long -> Long
        //    //float -> Float
        //    //double -> Double
        //    //char -> Character
        //}
    }
}
//Table trong database
//DB dùng để lưu trữ thông tin, dữ liệu
//Dữ liệu lưu trữ không luôn đc đầy đủ, có sẵn ngay mà từ từ bổ sung sau
//Ví dụ: table grade lưu điểm thi của sinh viên
//|KEY  |MÃ-SV  |MÃ LỚP HỌC |ĐIỂM PE    |ĐIỂM FINAL
// 1       x        x           ?           ?
//Các cột điểm chờ sẵn, điền vào sau, điểm mang trạng thái chưa có, chưa biết, chưa xác định
//Dao động từ 0..10 Nhưng hiện chưa biết
//double pe;    //-1 ko thể, ko nên biểu diễn là chưa biết
//-1 là điểm ko hợp lệ