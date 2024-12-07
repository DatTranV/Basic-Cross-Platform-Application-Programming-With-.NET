namespace StudentManagement.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Salary}";
        }
    }
}
