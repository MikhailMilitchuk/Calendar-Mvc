using CalendarMvcWebApplication.Hubs;
using CalendarMvcWebApplication.Models;
using System.Timers;

namespace CalendarMvcWebApplication.DataAccess
{
    public class EventRepository : IEventRepository
    {
        private IEnumerable<Event> events = default;

        public EventRepository() {
            ApplicationContext db = new ApplicationContext();
            events = db.Events;
        }

        public IEnumerable<Event> FilteredByDate(DateTime date)
        {
            return events.Where(e => e.Date.Date == date.Date);
        }
    }
}
