namespace CalendarMvcWebApplication.ViewModel
{
    public class CalendarViewModel
    {
        public DateTime Date { get; set; }
        public DayViewModel[,] Days { get; set; }
    }
}
