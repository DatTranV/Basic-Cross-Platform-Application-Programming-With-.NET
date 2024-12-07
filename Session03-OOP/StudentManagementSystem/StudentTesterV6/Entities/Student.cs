namespace StudentTesterV6.Entities
{
    public class Student
    {
        public Student()
        {
            
        }

        public Student(int id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        //public Student()
        //{
        //    // ko cần tạo vẫn tự động có
        //}

        //Nếu 1 class ko có constructor, thì runtime sẽ tự sinh cho mình 1 constructor rỗng như ở trên, mình ko cần tạo sẵn ra như ở trên
        //Nhưng nếu bạn chủ động tạo construtor rỗng như ở trên thì runtime sẽ ko tạo thêm CST rỗng nữa vì có rồi
        //CST rỗng (tự ngầm có, hay chủ động gõ) sẽ ko làm gì trên các field, cho nên mọi field sẽ mang giá trị default khi new object, vậy khi đó ta new theo style object initialization để set các giá trị cho object

        //nếu bạn chủ động tạo CST rỗng, thì có thể tạo nhanh bằng cách gõ CTOR TAB TAB

        //bạn vẫn có thể tạo thêm nhiều CST khác dùng để đổ info theo cách bạn muốn, đổ full, đổ từng phần
        //nhưng nếu 1 class có CST có tham số, thì runtime ko tạo CST default cho bạn, lí do: đã có phễu để đúc object rồi, tạo thêm cái default làm gì

        //tuy nhiên bạn có thể chủ động tạo luôn cả có tham số và default

        //gõ ctrl . -> CST để tạo nhanh cst có tham số

    }
}
