namespace StudentTesterV2.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string? ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";


        //phễu đổ thông tin vào
        //ctrl . chọn generate constructor, chọn các field cần đổ vào => Vì cho phép ta check vào các field cần đổ info
        //Ta suy ra được 1 điều: 1 class có nhiều CST tương ứng nhiều cách tạo ra object
        //Về lí thuyết 1 class có vô số constructor tùy vào số tổ hợp các field bạn muốn đổ vào!!
        //Nếu không đổ hết info thì các field còn lại mang giá trị bao nhiêu, giá trị gì? Mang giá trị default - giống như bỏ trống 1 số chỗ trên form/tờ giấy cần điền
        //số -> default là 0
        //chữ -> rỗng
        //Đúng sai -> sai, bool mặc định là false

        //tạo ra 1 object, có 1 object, ta sẽ có nhu cầu "độ" lại object, chỉnh sửa lại info
        //Ta tạo ra 1 trang fb cá nhân năm 2024, ngày đầu ta fill vào  cái hình avatar của 2024
        //Sang năm 2025, ta đổi lại avatar thành hình chụp tết cùng gia đình, ai vào fb của ta (cũ tạo năm 2024) ta lại thấy ảnh 2025
        //Thay đổi ảnh avatar ko làm ta bị mất cái fb cũ
        //Và cũng k tạo ra fb mới
        //Ta thay đổi hình nền của điện thoại của ta, vẫn là đt cũ của ta
        //Vậy việc thay đổi 1 object k tạo ra object mới mà chỉ là chỉnh sửa tình trạng của object cũ đang có
        //Hành động chỉnh sửa hiện trạng của 1 object gọi là set() setting() setter()

        //Nhóm hàm chỉnh sửa thông tin object
        public void SetYob(int yob)
        {
            _yob = yob;
        }
        //Style viết khá giống CST, tức là đều đổ info bên ngoài vào field; nhưng khác ở chỗ CST mỗi lần được gọi đi kèm toán tử new và tạo ra vùng ram mới để chứa object mới
        //Hàm Set() thì không tạo ra object mới mà đi tìm vùng object để sửa lại info đã đổ lần trước bằng info mới
        //Hàm Set() gọi cả vạn lần, k tạo ra object mới mà chỉ chỉnh cửa object cũ, như bạn có quyền sửa avatar vạn lần vẫn fb cũ
        //Giống: đè value mới vào cái _Field

        public void SetGpa(double gpa) => _gpa = gpa;

        //Viết Hàm Get()
        public string GetName() => _name;
        public void SetName(string name) => _name = name;

        //Java và C# và OOP nói chung đều phải viết bộ hàm Get() Set() rât nhàm chán, nhưng phải làm cho tất cả field đang có
        //Một class có x Fields, thì có tổng cộng
        //             x nhân 2 hàm Get() Set() nhàm chán
        //Phải làm k có gì thú vị => Boiler-Plate

        //Hàm Get Yob, Set Yob bản chất chẳng qua là lấy cái _yob trả ra bên ngoài cho ai đó dùng - Get
        //                                                   _yob = ??? chính là Set
        //1 Tên biến bất kì đã mang 2 ý nghĩa Get Set
        //ví dụ:
        //double total = 500000; //set tổng tiền = 500k
        //cw(total); get và in ra 500k từ biến total
        //tax = total * 0.08; // get total đc 500k rồi đem nhân
        //Có cần phải làm 2 hàm Get Set nhàm chán hay không, bao bên ngoài biến _name, _yob, _id, _gpa
        //Tiếp cận theo hướng tên biến là Get Set!!!

    }
}
