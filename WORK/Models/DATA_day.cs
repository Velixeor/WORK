using System.ComponentModel.DataAnnotations;

namespace WORK.Models
{
    public class DATA_day
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
