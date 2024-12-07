using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectType
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; } //primitive, value-type
        //1 thành phần đính kèm, đi theo Student
        public double Gpa { get; set; } //primitive, value-type
    }
}

//Class -> Object -> Thứ phức tạp vì gồm nhiều info bên trong
//Class -> Object -> Chứa nhiều data type khác bên trong
//Student là 1 data type chứa nhiều data type khác bên trong
//Student là đại diện cho bên trong nhiều info, hình thái biểu diễn dữ liệu phức tạp
//Student là Object Data type phức tạp, nó chứa primitive, object khác bên trong
//Trong ram thế nào?