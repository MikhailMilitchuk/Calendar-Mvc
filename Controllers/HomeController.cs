using CalendarMvcWebApplication.DataAccess;
using CalendarMvcWebApplication.Models;
using CalendarMvcWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalendarMvcWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStorage _storage;

        public HomeController(ILogger<HomeController> logger, IStorage storage)
        {
            _logger = logger;
            _storage = storage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calendar(int id)
        {
            return View(new CalendarViewModelBuilder(_storage).Build(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public string SubmitNote(DateTime time, string note)
        {
            return time.ToString() + " " + note;
        }
    }
}
