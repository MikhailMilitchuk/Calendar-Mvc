using CalendarMvcWebApplication.DataAccess;
using CalendarMvcWebApplication.Hubs;
using CalendarMvcWebApplication.Models;
using CalendarMvcWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CalendarMvcWebApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> Post([FromForm] EventViewModel ev)
        {
            ApplicationContext db = new ApplicationContext();
            db.Events.Add(new Event() { Id = db.Events.Count() + 1, Date = ev!.Date.ToUniversalTime().AddHours(3), Name = ev!.Name });
            await db.SaveChangesAsync();

            return Redirect("/Home/Calendar");
        }

        [HttpPost("Delete")]
        [Produces("application/json")]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            ApplicationContext db = new ApplicationContext();
            var itemRemove = db.Events.SingleOrDefault(x => x.Id == id);
            if(itemRemove != null)
            {
                db.Events.Remove(itemRemove);
            }
            await db.SaveChangesAsync();

            return Redirect("/Home/Calendar");
        }

        [HttpPost("Edit")]
        [Produces("application/json")]
        public async Task<IActionResult> Edit([FromForm] EventViewModel ev)
        {
            ApplicationContext db = new ApplicationContext();
            var itemEdit = db.Events.SingleOrDefault(x => x.Id == ev.Id);
            if (itemEdit != null)
            {
                itemEdit.Date = ev.Date.ToUniversalTime().AddHours(3);
                itemEdit.Name = ev.Name;
                db.Events.Update(itemEdit);
            }
            await db.SaveChangesAsync();

            return Redirect("/Home/Calendar");
        }
    }
}
