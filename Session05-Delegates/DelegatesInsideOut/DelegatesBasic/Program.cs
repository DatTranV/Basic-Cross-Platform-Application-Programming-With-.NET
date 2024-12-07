namespace DelegatesBasic
{
    //Tư duy OOP: Mọi thứ phức tạp đều có thể thuộc về 1 nhóm nào đó, tức là thuộc về 1 class nào đó
    //Quanh ta có nhiều con người có info ID, NAME, YOB...
    //              Nhưng những người này có thêm điểm trung bình, chuyên ngành => Nhóm này gọi là class Student
    //code cho nhóm này thế nào khi ta phát hiện ra 1 nhóm???
    public class Student  //DATA TYPE đại diện cho SV (id, name, yob, gpa, major...)
    {
        //đặc trưng
    }
    //Nói về 1 bạn cụ thể   Student     an =            new Student() {...};
    //                      data type  biến             value cụ thể, phức tạp
    //                                 đặt tên biến
    //                                 cụ thể cho object

    //public class  NoInputNoOutput //data type đại diện cho nhóm hàm void F()
    //{
    //    //...đặc trưng hàm, tên hàm
    //}
    //Nói về 1 hàm cụ thể đi
    //  NoInputNoOutput f1 = SayHello;

    //Vietsub: f1 là 1 hàm thuộc nhóm NoInputNoOutput và cụ thể nó là 
    //          hàm SayHello() ở dưới

    //Hãy gọi 2004 là yob, hãy gọi 3.14 là PI
    //Hãy gọi hàm SayHello là f1 => SayHello còn gọi là f1, f1 nhận ủy quyền delegate từ SayHello

    public delegate void NoInputNoOutput();
    //vietsub: NoInputNoOutput là tên gọi chung cho nhóm hàm ko vào ko ra 

    //câu hỏi: hàm SayHello() ở dưới có thuộc nhóm này hay ko???
    //         hàm double Math.Sqrt(int x) có thuộc nhóm này hay ko???
    //y chang câu hỏi: 3.14 có thuộc nhóm int ko???

    //khai báo biến thuôc nhóm và gán = value
    //nhóm int thì có hằng số c = 300000
    //nhóm Student thì có toiDiCodeDao = new Student() {...}
    //nhóm NoInputNoOutput thì có f1 = SayHello;

    //data, value cụ thể, thiếu nhóm, thiếu tên gọi riêng cho mỗi hàm
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutput f1 = SayHello;
            //gán value nên ko có (), vì sẽ bị hiểu nhầm thành gọi hàm
            //vietsub: f1 là 1 hàm thuộc nhóm ko vào ko ra và cụ thể là SayHello
            //vietsub: hãy gọi hàm SayHello là f1 cũng được
            //          hàm SayHello() có nick name là f1
            //          f1      =   SayHello;
            //         luật sư      thân chủ
            //thân chủ ủy quyền: delegate cho luật sư
            //kể từ nay về sau, hãy gọi SayHello là f1
            //f1 run() thì tương đương SayHello() run
            //luật sư phát ngôn, thân chủ phát ngôn
            //1 hàm lúc này có thêm tên gọi mới, delegate là cách đặt thêm nick name cho 1 hàm

            //Hãy gọi hàm SayHello() giùm tôi
            SayHello(); //Tầm thường
            f1(); //Luật sư phát biểu, cũng là thân chủ SayHello()

            f1 = SayHi;
            //Luật sư chơi với thân chủ mới
            //Luật sư phát ngôn (ủy quyền hành động - delegate trên hàm)
            f1();

            //luật sư tham việc, nhận ủy quyền của nhiều thân chủ luôn
            Console.WriteLine("Multicast delegates: "); //đa dạng ủy quyền
            f1 += GoAnGio;
            f1();
            //dồn các tên hàm, nhiều tên hàm được gọi chung 1 nick-name
            //"đám" genZ

            //f1 = ShowMessage; chửi vì ko match nhóm hàm
            //muốn chơi trò luật sư thân chủ với hàm ShowMessage ta cần tạo thêm delegate mới, nhóm hàm mới!!!
        }

        //Giả sử ta có nhiều hàm ko vào ko ra; bên cạnh đó, còn nhiều loại hàm khác, ví dụ có 1 vào, 2 vào, 3 vào,... ko ra
        //Có hàm ko vào, nhưng có ra: INT F() {}
        //..., Mình xét trước nhóm hàm ko vào ko ra, các nhóm còn lại tương tự
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void SayHello()
        {
            Console.WriteLine("Hello delegates");
        }
        static void SayHi()
        {
            Console.WriteLine("Anh trai say hi...");
        }
        static void GoAnGio()
        {
            Console.WriteLine("Dam gio ben con");
        }
    }
}
