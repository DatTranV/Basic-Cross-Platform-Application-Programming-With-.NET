namespace StudentTesterV4.Entities
{
    public class Student
    {
        private string _id;     //backing field
        private string _name;
        private int _yob;
        private double _gpa;

        public string Id      //property, prop
        {
            get => _id;
            set => _id = value;
        }
        //thiết kế class mà có backing field + hàm get set kiểu mới (property) thì được gọi là class theo style Full Property (Property đầy đủ hàm và _Backing Field)

        //Nếu bạn quên cú pháp, C# gợi ý cách gõ nhanh giúp bạn generate code code full prop
        //gõ propfull tab tab
        private int _a;

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public string Name      //property, prop
        {
            get => _name;
            set => _name = value;
        }

        public int Yob      //property, prop
        {
            get => _yob;
            set => _yob = value;
        }

        public double Gpa      //property, prop
        {
            get => _gpa;
            set => _gpa = value;
        }

    }
}
