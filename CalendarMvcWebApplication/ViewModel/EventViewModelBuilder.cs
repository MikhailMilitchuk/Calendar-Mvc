using CalendarMvcWebApplication.DataAccess;
using CalendarMvcWebApplication.Models;

namespace CalendarMvcWebApplication.ViewModel
{
    public class EventViewModelBuilder : ViewModelBuilderBase
    {
        public EventViewModelBuilder(IStorage storage) : base(storage)
        {
        }

        public EventViewModel Build(Event @event)
        {
            return new EventViewModel()
            {
                Id = @event.Id,
                Date = @event.Date,
                Name = @event.Name
            };
        }
    }
}
