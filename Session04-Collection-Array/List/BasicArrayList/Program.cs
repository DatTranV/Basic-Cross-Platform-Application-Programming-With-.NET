using System.Collections;

namespace BasicArrayList
{
    public class Student
    {
        public string Id { get; set; } //đằng sau chính là _id
        public string Name { get; set; }                  //_name
        public override string ToString() => $"{Id} | {Name}";

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithArrayList();
        }
        static void PlayWithArrayList()
        {
            ArrayList arr = new();
            arr.Add(1);
            arr.Add(-1);
            arr.Add(3.14);
            arr.Add("Hello");
            arr.Add('A');
            arr.Add(new Student() { Id = "SE1", Name = "An Nguyen" });

            //chứa lộn xộn, vậy in ra thế nào??
            //Danh sách này có vẻ vô nghĩa
            Console.WriteLine("The list of objects/items");
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);
            //Console.WriteLine(arr[5]);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}

//Để lưu trữ được nhiều object trong ram 1 cách hiệu quả, người ta có nhiều cách
//Cách 1: dùng mảng.
//                  [INDEX 0 ....LENGTH] chính là cách để truy xuất vào từng object trong đám đông trong ram
//                  Dễ dùng, dễ hiểu, nhưng bị hạn chế là
//                  -fix kích thước, ko thêm được
//                  -muốn thêm, thì phải new mảng mới
//                  -dữ liệu phải nằm sát nhau trong ram
//                  -không được for hết, mà chỉ for đến count
//                  -xóa 1 phần tử, 1 biến khỏi mảng, là xóa giả, ko xóa thật, là xóa theo style dồn chỗ lên, count--

//Cách 2: Dùng COLLECTIONS - bộ sưu tập
//          Là 1 loạt, 1 nhóm các class theo style cabinet, style thùng chứa, tức là những class này có sẵn ddeer ta dùng như mảng
//Chứa được nhiều thứ bên trong như cabinet, có các hàm CRUD để thêm, xóa, sửa data, xóa là xóa thật, giảm kích thước thùng chứa
//for đến hết, vì nó ko cấp phát dư/ dự phòng như mảng, xài đến đâu cấp đến đó
//thùng chứa linh hoạt, co giãn theo nhu cầu!!!
//xài mảng, xài nhóm class mới sẽ học này, cũng đều phải new, sau đó CRUD để quản lí các object
//object chứa nhiều object khác bên trong
//tủ cabinet được new chứa nhiều hồ sơ
//nhóm class này được gọi là COLLECTIONS, và nó sẽ gồm vừa:
//                  -Class cụ thể để ta new --> Concrete Class
//                  -Class Abstract, Interface để gom nhóm/phân loại ko được new
//Java ta có cơ bản hay dùng các class sau (~cabinet)
//ko được new:                      List                Set                 Map
//New được   :              ArrayList, Vector     HashSet, TreeSet     HashMap, TreeMap

//đám ở trên xài GENERIC, thì sẽ chứa được đa dạng các object đến từ các data type khác nhau
//Java: List<Student> arr = new ArrayList<Student>();
//                    arr.add(new Student(???));
//      Cabinet<Student> arr = new Cabinet();
//                       arr.Add(???);

//C# có khác biệt 1 chút trong cách đặt tên các nhóm class này, nhưng tương đồng với java

//ArrayList C# có, new được như java, nhưng không GENERIC
//ArrayList C# có thể add() tùm lum các loại object khác nhau của các data type khác nhau!!! Gây nên sự nguy hiểm ko an toàn khi cái túi, hộp chứa, tủ lộn xộn loại món đồ
//Dân chơi C# hầu như ko dùng class ArrayList vì nó lộn xộn bên trong, chơi đa dạng, chứa đa dạng
//Generic chơi đa dạng, chứa 1 loại
//Dân chơi C# sẽ dùng List<> để chơi đa dạng, tại 1 thời điểm chỉ chứa 1 loại
//Trong C# List tương đương ArrayList bên Java, đều new được, và Generic
//Còn ArrayList bên C# là đồ bỏ