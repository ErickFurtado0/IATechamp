namespace IATechamp.Models
{
    public class EventModel
    {
        public EventModel()
        {
        }

        public EventModel(int idEvent, DateTime dateEvent)
        {
            IdEvent = idEvent;
            DateEvent = dateEvent;
        }

        public int IdEvent { get; set; }
        public DateTime DateEvent { get; set; }

    }
}
