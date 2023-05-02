using System.ComponentModel.DataAnnotations;

namespace WORK.Models
{
    public class DATA_day
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int NumberDay { get; set; }
        public virtual DATA_month DATA_month { get; set; }

        public virtual ICollection<DATA_event> Events { get; set; }
    }
}
