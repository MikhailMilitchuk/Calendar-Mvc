namespace CalendarMvcWebApplication.DataAccess
{
    public class Storage : IStorage
    {
        public IEventRepository EventRepository { get; private set; }

        public Storage()
        {
            this.EventRepository = new EventRepository();
        }
    }
}
