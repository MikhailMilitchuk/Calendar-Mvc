using CalendarMvcWebApplication.DataAccess;
using CalendarMvcWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CalendarMvcWebApplication.Controllers
{
    public class CalendarController : Controller
    {
        private IStorage storage;

        public CalendarController(IStorage storage)
        {
            this.storage = storage;
        }

        public ActionResult Calendar(int id)
        {
            return this.View(new CalendarViewModelBuilder(this.storage).Build(id));
        }
    }
}
