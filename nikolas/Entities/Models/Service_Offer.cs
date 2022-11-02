namespace nikolas.Entities.Models
{
    public class Service_Offer
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int OfferID { get; set; }
        public Offer Offer { get; set; }

        public int Service_OfferQuantity { get; set; }
        public int Service_OfferDiscount { get; set; }
    }
}
