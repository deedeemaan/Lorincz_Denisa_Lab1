using Microsoft.AspNetCore.Mvc;

namespace Lorincz_Denisa_Lab1.Controllers
{
    public class MyProject : Controller
    {
        public string Index()
        {
            return "Bun venit în aplicatia mea MVC!";
        }

        // 2️ Metoda personalizata – salut
        public string Salut()
        {
            return "Salut, utilizator! Sper să ai o zi frumoasă!";
        }

        // 3️ Metoda cu parametri (string + int)
        public string Afiseaza(string nume, int varsta)
        {
            return $"Salut {nume}, ai {varsta} ani!";
        }
    }
}
