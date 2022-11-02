using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nikolas.Entities.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey(nameof(User))]
        public int  UserId{ get; set; }
        public User? USers { get; set; }
        public  ICollection<Order_Material>? Order_Materials { get; set; }

    }
}
