using StudentTesterV2.Entities;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateObjects();
        }
        static void CreateObjects()
        {
            Student an = new("SE1", "An Nguyen");
            Console.WriteLine("An Full: " + an); //GPA và DOB đang default, mang giá trị 0
            //Sửa điểm, sửa năm sinh, bổ sung hồ sơ sau
            //Màn hình register, cho phép bỏ trống một số chỗ
            //Từ từ edit lại
            an.SetYob(2005);
            an.SetGpa(8.6);
            Console.WriteLine("After Updating...");
            Console.WriteLine("An Full again: {0}", an);
        }
    }
}
