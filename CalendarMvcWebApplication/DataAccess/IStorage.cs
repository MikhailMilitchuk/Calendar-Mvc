namespace CalendarMvcWebApplication.DataAccess
{
    public interface IStorage
    {
        IEventRepository EventRepository { get; }
    }
}
