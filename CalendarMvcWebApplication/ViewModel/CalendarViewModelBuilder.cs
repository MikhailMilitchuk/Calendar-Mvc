using CalendarMvcWebApplication.DataAccess;

namespace CalendarMvcWebApplication.ViewModel
{
    public class CalendarViewModelBuilder : ViewModelBuilderBase
    {
        public CalendarViewModelBuilder(IStorage storage) : base(storage)
        {
        }

        public CalendarViewModel Build(int id)
        {
            if (id == 0)
            {
                id = DateTime.Now.Month;
            }
            DayViewModel[,] days = new DayViewModel[6, 7];

            DateTime date = new(DateTime.Now.Year, id, 1);
            
            int offset = (int)date.DayOfWeek;

            if (offset == 0)
                offset = 7;

            offset--;
            date = date.AddDays(offset * -1);

            for (int i = 0; i != 6; i++)
            {
                for (int j = 0; j != 7; j++)
                {
                    days[i, j] = new DayViewModelBuilder(this.Storage).Build(date);
                    date = date.AddDays(1);
                }
            }

            return new CalendarViewModel()
            {
                Date = DateTime.Now,
                Days = days
            };
        }
    }
}
