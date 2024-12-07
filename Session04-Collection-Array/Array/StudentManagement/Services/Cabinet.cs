using StudentManagement.Entities;

namespace StudentManagement.Services
{
    public class Cabinet
    {
        private Student[] _arr = new Student[30];
        private int _count = 0; //biến count dùng để lưu số phần tử đang có trong mảng, vì mảng object ko nên for đến hết trừ khi mảng đã full vì coi chừng null reference, trỏ null

        //Bài này ta ko xài style property vì
        //nếu xài prop thì .Count = 500 nghĩa là tự nhiên cái tủ có 500 hồ sơ khống
        //Count phải tự tăng khi có thêm từng người từng hồ sơ được add thêm
        //Nếu xài prop thì .Arr = 1 cái mảng khác đưa vào, tức là mang ý nghĩa của 1 đám hồ sơ bay vèo vào tủ, nghe ko thật

        //Hàm CRUD từng hồ sơ sv
        //ko cần làm constructor vì mảng từ từ được bỏ thêm hồ sơ
        //khi new cái tủ có sẵn 30 chỗ và count = 0, cần gì constructor
        //lúc này khi new cái Cabinet ta xài default/empty constructor

        public void AddStudent(string id, string name, int yob, double gpa)
        {
            //TODO: Check full mảng
            _arr[_count] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
            _count++;

        }
        public void AddStudent(Student obj)
        {
            //TODO: Check full mảng
            _arr[_count++] = obj; //new ở đâu không biết, cho tớ trỏ cùng
        }

        //In danh sách 
        public void PrintStudentList()
        {
            if (_count == 0)
            {
                Console.WriteLine("There is no student in the list. Add student first please");
                return; //early return
            }
            Console.WriteLine($"There is/are {_count} student(s) in the list. Here they/it are/is ");
            for (int i = 0; i < _count; i++)
            { //cấm for đến hết vì con trỏ null null pointer reference
                Console.WriteLine(_arr[i]);

            }
        }
    }
}
//Cabinet là 1 cái tủ, có nhiều không gian bên trong để chứa nhiều món đồ
//cái tủ có được những hành động: Thêm đồ, Xóa đồ, Sắp xếp đồ... CRUD

//Cái tủ mà có ko gian bên trong để chứa nhiều đồ
//~~~Ta khai báo 1 cái mảng để chứa nhiều object

//Ta sẽ làm các hành động thêm xóa sửa tìm sắp xếp trên mảng ~~~ CRUD trên cái tủ

//Cabinet chỉ lo làm crud món đồ, crud hồ sơ sinh viên
//Class student chỉ lo lưu trử info của từng sv
//Ai giỏi việc nào làm việc nấy, nguyên lý S - Single Responsibility của nguyên lý tổng SOLID (rảnh thì nên đọc về nó, vì đó là kĩ thuật thiết kế class nâng cao)