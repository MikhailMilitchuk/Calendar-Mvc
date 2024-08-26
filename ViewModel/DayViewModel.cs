namespace CalendarMvcWebApplication.ViewModel
{
    public class DayViewModel
    {
        public DateTime Date { get; set; }
        public bool IsNotCurrentMonth { get; set; }
        public bool IsWeekendOrHoliday { get; set; }
        public bool IsToday { get; set; }
        public IEnumerable<EventViewModel> Events { get; set; }
    }
}
