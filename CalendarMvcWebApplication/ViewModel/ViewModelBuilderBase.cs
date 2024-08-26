using CalendarMvcWebApplication.DataAccess;

namespace CalendarMvcWebApplication.ViewModel
{
    public class ViewModelBuilderBase
    {
        protected IStorage Storage { get; private set; }

        public ViewModelBuilderBase(IStorage storage)
        {
            this.Storage = storage;
        }
    }
}
