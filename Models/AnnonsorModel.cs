namespace AnnonsSystem.Models
{
    public class AnnonsorModel
    {
        //id, type, namn, organisationsnummer, telefonnummer, utdelningsadress, postnummer samt ort plus fakturaadress som innehåller utdelningsadress, postnummer samt ort.
        public int Id { get; set; }
        public string Typ { get; set; } // Typ (privatperson eller företag)
        public string Namn { get; set; }
        public string Organisationsnummer { get; set; }
        public string Telefonnummer { get; set; }
        public string Utdelningsadress { get; set; }
        public string Postnummer { get; set; }
        public string Ort { get; set; }
        public string Faktura_utdelningsadress { get; set; }
        public string Faktura_postnummer { get; set; }
        public string Faktura_ort { get; set; }
    }
}
