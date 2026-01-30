using Microsoft.AspNetCore.Mvc;

namespace AylaSenturk.Portfolio.Controllers
{
    /// <summary>
    /// Portfolio sayfalari controller'i
    /// Ana Sayfa, Projeler, Makaleler, Iletisim, CV
    /// </summary>
    public class PortfolioController : Controller
    {
        /// <summary>
        /// Ana Sayfa
        /// </summary>
        public IActionResult Index()
        {
            ViewData["Title"] = "Ana Sayfa - Ayla Senturk Portfolio";
            return View();
        }

        /// <summary>
        /// Projeler sayfasi
        /// </summary>
        public IActionResult Projects()
        {
            ViewData["Title"] = "Projeler - Ayla Senturk Portfolio";
            return View();
        }

        /// <summary>
        /// Makaleler sayfasi
        /// </summary>
        public IActionResult Articles()
        {
            ViewData["Title"] = "Makaleler - Ayla Senturk Portfolio";
            return View();
        }

        /// <summary>
        /// Iletisim sayfasi
        /// </summary>
        public IActionResult Contact()
        {
            ViewData["Title"] = "Iletisim - Ayla Senturk Portfolio";
            return View();
        }

        /// <summary>
        /// CV / Ozgecmis sayfasi
        /// </summary>
        public IActionResult Resume()
        {
            ViewData["Title"] = "Ozgecmis - Ayla Senturk Portfolio";
            return View();
        }
    }
}
