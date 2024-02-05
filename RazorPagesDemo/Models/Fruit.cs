namespace RazorPagesDemo.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Desc { get; set; }

        public Fruit(int id, string name, string desc)
        {
            Id = id;
            Name = name;
            Desc = desc;
        }
    }
}
