namespace StudentTesterV3.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        private string _address;

        public Student(string id, string name, int yob, double gpa, string address)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
            _address = address;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        //Get Set Style boiler plate - Truyền Thống
        //public string Id { get { return _id; };
        public string GetId()
        {
            return _id;
        }
        public void SetId(string id)
        {
            _id = id;
        }

        //C# đề xuất cách viết Get Set kiểu mới tránh nhàm chán, kết quả cuối cùng thì cũng tương đương truyền thống
        //C# dùng ý tưởng bản thân 1 biến bất kì đã mang 2 ý nghĩa Get và Set
        //C# đề nghị bạn tạo thêm 1 "biến lai" lai giữa biến và hàm

        //get set cho _name, viết style mới
        public string Name //= "An Nguyen"
        {
            get { return _name; }
            set { _name = value; }
        }
        //.Name -> get được _name rồi
        //.Name = "An Nguyễn" -> An nguyễn đc đổ vào value
        //Value đi vào _name -> Hàm Set truyền thống đã chạy
        //Ngày xưa .GetName(), Ngày nay: .Name
        //Ngày xưa .SetName(), Ngày nay: .Name = "An"

        //Hãy xem name là cái mặt tiền, cái biến quầy tiếp tân
        //Biến bồi bàn, còn _name là nhà bếp, đầu bếp, hậu trường chống lưng phục vụ thằng Name bên ngoài
        //_name: gọi tên mới là Backing Field. Em là thằng chống lưng value cho thằng Name tiếp tân bên ngoài

        //Nane: property, 1 đặc trưng của 1 project

        public int Yob //=2004
        {
            get { return _yob; }
            set { _yob = value; }
        }

        public double Gpa
        {
            get => _gpa;        //em trả về backing field
            set => _gpa = value; //backing field = gì đó
        }
        //.Gpa = 8.6
        //cw(Gpa)
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        //.Address 
        //.Address =
    }
}
