using Microsoft.AspNetCore.Mvc;

namespace AylaSenturk.Portfolio.Controllers
{
    /// <summary>
    /// API Entegrasyonlari controller'i
    /// GitHub Rastgele Depo, Reddit Istemcisi, Trafik Malzemeleri
    /// </summary>
    public class ApiController : Controller
    {
        /// <summary>
        /// GitHub Rastgele Depo
        /// </summary>
        public IActionResult GitHubRandom()
        {
            ViewData["Title"] = "GitHub Rastgele Depo";
            return View();
        }

        /// <summary>
        /// Reddit Istemcisi
        /// </summary>
        public IActionResult RedditClient()
        {
            ViewData["Title"] = "Reddit Istemcisi";
            return View();
        }

        /// <summary>
        /// Trafik Malzemeleri Katalogu
        /// </summary>
        public IActionResult TrafficMaterials()
        {
            ViewData["Title"] = "Trafik Malzemeleri Katalogu";
            return View();
        }
    }
}
