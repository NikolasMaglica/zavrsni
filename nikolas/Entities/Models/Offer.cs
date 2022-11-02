using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nikolas.Entities.Models
{
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public int OfferPrice { get; set; }
        [ForeignKey("Dept")]
        public int ClientId { get; set; }
        public virtual Client Clients { get; set; }
        [ForeignKey("Depts")]
        public int UserId { get; set; }
        public virtual User Users { get; set; }

        [ForeignKey("Deptsa")]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicles { get; set; }

        [ForeignKey("Deptsas")]
        public int Offer_StatusID { get; set; }
        public virtual Offer_Status Offer_Statuses { get; set; }


        public ICollection<Material_Offer> Material_Offers { get; set; }

        public ICollection<Service_Offer> Service_Offers { get; set; }


    }
}
