using CalendarMvcWebApplication.Models;

namespace CalendarMvcWebApplication.DataAccess
{
    public class EventRepository : IEventRepository
    {
        private readonly IEnumerable<Event> events = default;

        public EventRepository() {
            ApplicationContext db = new ApplicationContext();
            events = db.Events;
        }

        public IEnumerable<Event> FilteredByDate(DateTime date)
        {
            return this.events.Where(e => e.Date.Date == date.Date);
        }
    }
}
