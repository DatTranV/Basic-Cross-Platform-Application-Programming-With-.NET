namespace SchoolManagement.Entities
{
    public class Fish
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string? ToString()
        {
            return $"FISH: {Id} | {Name}";
        }
    }
}
