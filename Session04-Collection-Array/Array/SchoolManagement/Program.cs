using SchoolManagement.Entities;
using SchoolManagement.Services;

namespace SchoolManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet<Fish> fishC = new(30);
            Cabinet<Student> studentC = new(300);

            fishC.AddItem(new Fish() { Id = "K1", Name = "KOI 1" });
            studentC.AddItem(new Student() { Id = "SE1", Name = "Dat", Yob = 2005, Gpa = 8.6 });
            Console.WriteLine("Student List: ");
            studentC.PrintList();
            Console.WriteLine("Fish List: ");
            fishC.PrintList();

        }
    }
}
