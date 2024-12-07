using StudentManagement.Entities;

namespace StudentManagement.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arr; //ko new sẵn cái mảng
        private int _count = 0;

        //bài này ta cải tiến cái tủ sẽ đóng bằng cách đóng 1 cái tủ linh hoạt size, to nhỏ do bên ngoài đưa vào qua constructor. Muốn tủ to, đưa size kích thước bự, muốn tủ nhỏ đưa size kích thước nhỏ 

        //Điều gì xảy ra nếu đưa kích thước âm??
        //c1: chửi, ko cho tạo object
        //c2: tạo 1 cái tủ có kích thước mặc định!!!
        //public LecturerCabinet(int size)
        //{
        //    if (size <= 0) throw new ArgumentOutOfRangeException("Invalid size");

        //    arr = new Lecturer[size];
        //}

        public LecturerCabinet(int size)
        {
            if (size < 0) size = 6368;
            _arr = new Lecturer[size];
        }

        //Code còn lại y chang, vì thêm hồ sơ sv thì cx giống thêm hồ sơ gv, đơn hàng, sản phẩm
        //In danh sách sv y chang  in danh sach giảng viên

        public void AddLecture(Lecturer obj)
        {

            //if (_count == length) thông báo và return
            _arr[_count++] = obj;
        }

        public void AddLecture(string id, string name, int yob, double salary)
        {
            _arr[_count++] = new Lecturer() { Id = id, Name = name, Yob = yob, Salary = salary };

        }
        public void PrintLectureList()
        {
            if (_count == 0)
            {
                Console.WriteLine("There is no lecture. Please add one first!");
                return;
            }
            Console.WriteLine("Lecture: ");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i].ToString());
            }
        }

        //Khi bạn tạo constructor, mà có ném ra ngoại lệ trong 1 số tình huống tham số đầu vào không hợp lê, thì ngoại lệ sẽ gây ra việc phải dừng app lại hoặc bắt xử lí ở trong try - catch
        //Khi cpu chạy vào phần catch, đồng nghĩa với việc hàm ko thành công, constructor chạy ko thành công, object ko bao giờ dc tạo ra
        //Nếu constructor nhận tham số bị gây exception, thì object coi như chưa được new!
    }
}
