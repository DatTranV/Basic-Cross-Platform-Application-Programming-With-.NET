namespace StudentTester.Entities
{
    //class nó như 1 cái khuôn, cái form, cái biểu mẫu, cái dàn khung, cái template có chừa sẵn nhiều chỗ để điền thông tin, dữ liệu, vật liệu vào bên trong
    //mold, template, blue-print, skeleton
    //class Student là cái form, biểu mẫu, tờ giấy chừ sẵn chỗ trống id, name, yob, address để mình fill vào thành 1 hồ sơ cụ thể nào đó, cụ thể tức là 1 object.
    //Từ class Student clone ra được nhiều hồ sơ cụ thể -> object
    public class Student
    {
        private string _id; //ID : [_________]
        //Java : khong co _
        private string _name;
        private int _yob;
        private double _gpa;

        //cần có 1 cái hành động gì đó để ddienf info vào: lấy cây bút
        //cần có 1 cái hành động gì đó đẻ đổ vật liệu từ bên ngoài cái khuôn vào trong bên trong
        //ta đi lấy cái phễu, để đổ rót từ ngoài vào trong khuôn
        //ứng với 1 hàm trong code, hứng tham số bên ngoài
        //để tạo ra 1 object, 1 biểu mẫu đc điền
        //Tạo ra -> construct 
        //phương tiện giúp tạo ra -> constructor
        //ta tạo 1 cái hàm được gọi là constructor để nhận info bên ngooài
        public Student(string id, string name, int yob, double gpa)
        {
            this._id = id; //tương đương hành động cầm cây bút điền vào form giấy. This là dư thừa do không có sự nhầm lẫn tên biến trong và ngoài
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        //Phễu, Constructor là hàm đặc biệt, ứng với hành động đem khuôn ra đổ vật liệu vào, đem form biểu mẫu ra lấy bút vẽ chữ vào
        //=> Giúp ra được 1 object, 1 thứ duy nhất khác biệt
        //Từ class, từ khuôn ra nhiều object, cứ đổ vào là có
        //Hành động đổ vào và có object gọi là new, tạo mới
        //Cái phễu, cái hàm constructor quy tắc viết như sau:
        //Tên hàm constructor (CST) 100% trùng tên với tên class
        //Hàm constructor ko có giá trị trả về, ko void luôn
        //Có bao nhiêu CST trong 1 class??
        //Thường 99,9% constructor là public!
        //0.0001% là dùng private
        //Singleton design pattern!!
        //Design Patterns (GOF = Gang Of Four) -> để apply vị trí tuyển dụng SA - soulution architec, lương khoảng 5000$/tháng ở VN
        //Sau khi đã đổ info vào tờ giấy, khuôn, lúc này info sẽ nằm ở các _field, đó là lúc ta flex thong tin này ra
        //Ví dụ bạn Student(có điểm thi cuối kì các môn)
        //Sau đó bạn ấy flex cái chữ passed trên fb
        //Đây ứng với các hàm Get() Show() ToString()
        public string GetName()
        {
            return _name;
        }
        public int GetYob()
        {
            return _yob;
        }
        public double GetGgpa() => _gpa;

        //Nếu hàm chỉ có duy nhất 1 câu lệnh, được quyền rút gọn, loại bỏ bớt các chi tiết thừ: {} return. Hàm còn rất ngắn gọn
        //Cú pháp ngắn gọn này được gọi là expresion body, expression bodied
        //Thân hàm rút gọn như là biểu thức

        //Mình hay show full info giống như đưa cccd, show profile trên fb
        //public void FlexProfile()
        //{
        //    Console.WriteLine($"{_id} | {_name} | {_yob} | {_gpa}");
        //}

        public void FlexProfile() => Console.WriteLine($"{_id} | {_name} | {_yob} | {_gpa}");

        //@Override Java
        //public override string ToString()
        //{
        //    return $"{_id} | {_name} | {_yob} | {_gpa}";
        //}

        public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";


    }
}
