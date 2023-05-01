using System.ComponentModel.DataAnnotations;

namespace WORK.Models
{
    public class DATA_event
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public virtual DATA_day DATA_day { get; set; }
        public string categori { get; set; }
    }
}
