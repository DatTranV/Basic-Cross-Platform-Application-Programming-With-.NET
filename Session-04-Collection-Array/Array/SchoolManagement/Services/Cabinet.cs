using SchoolManagement.Entities;

namespace SchoolManagement.Services
{
    public class Cabinet<T>
    {
        private T[] _arr;
        private int _count = 0;
        public Cabinet(int size)
        {
            if (size < 0) throw new ArgumentOutOfRangeException("size");
            _arr = new T[size];
        }

        public void AddItem(T obj)
        {
            _arr[_count++] = obj;
        }

        public void PrintList()
        {
            if (_count < 0)
            {
                Console.WriteLine("There is no item. Add firt!");
                return;
            }
            Console.WriteLine("Item: ");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i].ToString());
            }
        }
        //private Lecturer[] _arrL;
        //private Student[] _arrS;
        //private Fish[] _arrF;
        //cách viết cũ, mỗi Cabinet khác nhau, 1 mảng khác nhau, theo S của SOLID, mỗi class chỉ giải quyết 1 công việc
        //code thì giống nhau, chỉ khác data type của mảng
        //vậy thì ta theo cách tiếp cận mới: data type coi như là tham số chưa biết luôn, sẽ giúp class deal đc với đa dạng data type
        //Kĩ thuật thiết kế hàm hay class mà chơi với đa dạng, chưa biết data type - gọi là GENERIC (tổng quát, chung chung)
        //t chỉ biết t sẽ chơi với 1 data type nào đó mà thôi
        //void F(int x) -> value là chưa biết số nào nhưng biết rõ data type int, x là int
        //void F(T x) có 2 thứ chưa biết
        //T có thể là int, quay lại ở trên, tìm x là int
        //T có thể là double, quay lại ở trên, tìm x là double
        //T: type chưa biết
        //hàm nhận vào 2 tham số: T và x 
        //viết hàm kiểu này sẽ giúp hàm chơi với nhiều loại data type
        //class cũng y chang, nếu ta muốn class Cabinet chơi với đa dạng các Array khác nhau, thì Cabinet<T> chính là giúp truyền vào type của mảng muốn lưu trữ
        //T có thể là Student, Lecture,...
        //1 class đa dạng mảng bên trong
        //ArrayList sau này cũng dùng cùng cách tiếp cận
    }
}
