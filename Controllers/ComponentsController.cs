using Microsoft.AspNetCore.Mvc;

namespace AylaSenturk.Portfolio.Controllers
{
    /// <summary>
    /// UI Bilesenleri controller'i
    /// Flashcards, Tabs, Tooltip, TextareaLimited, CookieConsent, AccessibleForm, DigitalId, ReferenceCards, Changelog
    /// </summary>
    public class ComponentsController : Controller
    {
        /// <summary>
        /// Bilgi Kartlari (Flashcards)
        /// </summary>
        public IActionResult Flashcards()
        {
            ViewData["Title"] = "Bilgi Kartlari";
            return View();
        }

        /// <summary>
        /// Sekmeler (Tabs)
        /// </summary>
        public IActionResult Tabs()
        {
            ViewData["Title"] = "Sekmeler";
            return View();
        }

        /// <summary>
        /// Ipucu Arayuzu (Tooltip)
        /// </summary>
        public IActionResult Tooltip()
        {
            ViewData["Title"] = "Ipucu Arayuzu";
            return View();
        }

        /// <summary>
        /// Kisitli Metin Alani
        /// </summary>
        public IActionResult TextareaLimited()
        {
            ViewData["Title"] = "Kisitli Metin Alani";
            return View();
        }

        /// <summary>
        /// Cerez Onayi
        /// </summary>
        public IActionResult CookieConsent()
        {
            ViewData["Title"] = "Cerez Onayi";
            return View();
        }

        /// <summary>
        /// Erisebilir Form
        /// </summary>
        public IActionResult AccessibleForm()
        {
            ViewData["Title"] = "Erisebilir Form";
            return View();
        }

        /// <summary>
        /// Dijital Kimlik
        /// </summary>
        public IActionResult DigitalId()
        {
            ViewData["Title"] = "Dijital Kimlik Denetimi";
            return View();
        }

        /// <summary>
        /// Referans Kartlari
        /// </summary>
        public IActionResult ReferenceCards()
        {
            ViewData["Title"] = "Referans Kartlari";
            return View();
        }

        /// <summary>
        /// Degisiklik Gunlugu
        /// </summary>
        public IActionResult Changelog()
        {
            ViewData["Title"] = "Degisiklik Gunlugu";
            return View();
        }
    }
}
