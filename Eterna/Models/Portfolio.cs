namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ProjectUrl { get; set; }
        public string Client { get; set; }
        public DateTime ProjeDate { get; set; }
        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }
    }
}
