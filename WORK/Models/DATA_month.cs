using System.ComponentModel.DataAnnotations;

namespace WORK.Models
{
    public class DATA_month
    {
        [Key]
        public int id { get; set; }
        public string name{ get; set; }
        public virtual ICollection<DATA_day> Days { get; set; }
    }
}
