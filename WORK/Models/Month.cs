namespace WORK.Models
{
    public class Month
    {
        public List<DAY> DAYS { get; } = new List<DAY>();
        string Name = "MAY";
        public Month(DAY _DAY) { 
            DAYS.Add(_DAY);
        }
        public DAY GetEvent(int i)
        {
            return DAYS[i];
        }
    }
}
