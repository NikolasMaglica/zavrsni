using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace nikolas.Entities.Models
{
    public class User
    {
        [Key]

        public int id { get; set; }
        
        public string firstname { get; set; }= String.Empty;
       
        public string lastname { get; set; }= String.Empty;
       
        public string username { get; set; }= String.Empty;
       
        public string password { get; set; }= String.Empty;
        public virtual ICollection<Offer>? Offers { get; set; }
        public ICollection<Order>? Orders { get; set; }



    }
}
