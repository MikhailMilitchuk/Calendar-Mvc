using System.ComponentModel.DataAnnotations;

namespace CalendarMvcWebApplication.ViewModel
{
    public class EventViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
