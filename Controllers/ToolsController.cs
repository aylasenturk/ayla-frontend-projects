using Microsoft.AspNetCore.Mvc;

namespace AylaSenturk.Portfolio.Controllers
{
    /// <summary>
    /// Uretkenlik araclari controller'i
    /// Pomodoro, Gorev Takipcisi, Tarih Secici, Sicaklik Donusturucu, Yas Hesaplayici
    /// </summary>
    public class ToolsController : Controller
    {
        /// <summary>
        /// Pomodoro Zamanlayici
        /// </summary>
        public IActionResult Pomodoro()
        {
            ViewData["Title"] = "Pomodoro Zamanlayici";
            return View();
        }

        /// <summary>
        /// Gorev Takipcisi
        /// </summary>
        public IActionResult TaskTracker()
        {
            ViewData["Title"] = "Gorev Takipcisi";
            return View();
        }

        /// <summary>
        /// Tarih Secici
        /// </summary>
        public IActionResult DatePicker()
        {
            ViewData["Title"] = "Tarih Secici";
            return View();
        }

        /// <summary>
        /// Sicaklik Donusturucu
        /// </summary>
        public IActionResult TemperatureConverter()
        {
            ViewData["Title"] = "Sicaklik Donusturucu";
            return View();
        }

        /// <summary>
        /// Yas Hesaplayici
        /// </summary>
        public IActionResult AgeCalculator()
        {
            ViewData["Title"] = "Yas Hesaplayici";
            return View();
        }
    }
}
