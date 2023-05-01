using System.ComponentModel.DataAnnotations;

namespace WORK.Models
{
    public class DATA_event
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string name1 { get; set; }
        public string categori { get; set; }
    }
}
