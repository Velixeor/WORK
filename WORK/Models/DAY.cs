namespace WORK.Models
{
    public class DAY
    {

        public List<Event> Events { get; } = new List<Event>();
        string Name = "Test";
        // Конструктор класса
        public DAY(Event _Event)
        {
            Events.Add(_Event);
        }


        public Event GetEvent(int i)
        {
            return Events[i];
        }
    }
}
