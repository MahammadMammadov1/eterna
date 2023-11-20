namespace Eterna.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Portfolio> Portfolio { get; set; }
    }
}
