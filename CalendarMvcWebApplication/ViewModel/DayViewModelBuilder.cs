using CalendarMvcWebApplication.DataAccess;

namespace CalendarMvcWebApplication.ViewModel
{
    public class DayViewModelBuilder : ViewModelBuilderBase
    {
        public DayViewModelBuilder(IStorage storage) : base(storage)
        {
        }

        public DayViewModel Build(DateTime date)
        {
            return new DayViewModel()
            {
                Date = date,
                IsNotCurrentMonth = date.Month != DateTime.Now.Month,
                IsWeekendOrHoliday = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday,
                IsToday = date.Date == DateTime.Now.Date,
                Events = this.Storage.EventRepository.FilteredByDate(date).Select(
                e => new EventViewModelBuilder(this.Storage).Build(e)
              )
            };
        }
    }
}
