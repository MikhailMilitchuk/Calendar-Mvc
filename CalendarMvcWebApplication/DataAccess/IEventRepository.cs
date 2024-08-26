using CalendarMvcWebApplication.Models;

namespace CalendarMvcWebApplication.DataAccess
{
    public interface IEventRepository
    {
        IEnumerable<Event> FilteredByDate(DateTime date);
    }
}
