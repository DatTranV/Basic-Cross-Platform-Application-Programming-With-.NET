namespace SchoolManagement.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString()
        {
            return $"STUDENT: {Id} | {Name} | {Yob} | {Gpa}";
        }
    }
}
