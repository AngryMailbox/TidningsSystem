using AnnonsSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnnonsSystem.Controllers
{
    public class AnnonsorController : Controller
    {
        static IList<AnnonsorModel> annonsorList = new List<AnnonsorModel>
            {
                new AnnonsorModel() { Id = 1, Typ = "Privatperson", Namn = "John Doe", Organisationsnummer = "1234567890", Telefonnummer = "0701234567", Utdelningsadress = "Storgatan 1", Postnummer = "12345", Ort = "Stockholm", Faktura_utdelningsadress = "Storgatan 1", Faktura_postnummer = "12345", Faktura_ort = "Stockholm" },
                new AnnonsorModel() { Id = 2, Typ = "Företag", Namn = "ABC AB", Organisationsnummer = "9876543210", Telefonnummer = "0707929238", Utdelningsadress = "Vasagatan 2", Postnummer = "54321", Ort = "Göteborg", Faktura_utdelningsadress = "Vasagatan 2", Faktura_postnummer = "54321", Faktura_ort = "Göteborg" }
            };

        // GET: Annonsorer
        public IActionResult Annonsorer()
        {
            //fetch annonsorer from database
            return View(annonsorList);
        }
    }
}
