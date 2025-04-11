namespace AnnonsSystem.Models
{
    public class AnnonsModel
    {
        //id, varans pris, innehåll, rubrik och annonspris
        public int Id { get; set; }
        public decimal pris { get; set; }
        public string innehall { get; set; }
        public string rubrik { get; set; }
        public decimal annonspris { get; set; }
    }
}
