namespace WORK.Models
{
    public class DAY
    {

        public List<Event> Events { get; } = new List<Event>();
        string Name;
        int Number_Day;
        public DAY(Event _Event)
        {
            Events.Add(_Event);
        }
        public DAY()
        {
            
        }


        public Event GetEvent(int i)
        {
            return Events[i];
        }
    }
}
