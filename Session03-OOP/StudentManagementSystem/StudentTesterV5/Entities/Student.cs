namespace StudentTesterV5.Entities
{
    public class Student
    {

        public string Id { get; set; } //_id sẽ tự generate ngầm
        public string Name { get; set; } //_name backing field tự generate ngầm
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //Viết prop nhưng che dấu backing field, từ generate khi runtime 
        //Tránh boiler plate 
        //Kĩ thuật này gọi là Auto-Implemented Property
        //Tức là kĩ thuật từ generate backing field
        //Nếu lỡ quên cú pháp thì gõ prop tab tab
        //.Id là get() rồi
        //.Id = "SE12345" là set() rồi
        
        //public int MyProperty { get; set; }

        
        ////private int myVar;
        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set {if(value > 5 ) myVar = value; }
        //}
        //cái lợi của propfull có backing field là có thể kiểm tra được dữ liệu đầu vào còn Auto-Implemented Property thì không

    }
}

//JAva phải viết code get set theo style truyền thống
//N x 2 hàm get set
//C# siêu gọn nhẹ
//Java có 1 nhóm dev biết rằng get set truyền thống rất nhàm chán, độ thêm một thư viện bổ sung cho dân dev làm get set nhanh gọn như C# nhưng ko gọi là prop, vì đây là hàng không chính hãng
//thư viện lombok