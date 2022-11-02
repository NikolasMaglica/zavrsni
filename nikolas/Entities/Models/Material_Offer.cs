namespace nikolas.Entities.Models
{
    public class Material_Offer
    {
     

        public int MaterialID { get; set; }
        public Material? Material { get; set; }
        public int OfferID { get; set; }
        public Offer? Offer { get; set; }

        public int Material_OfferQuantity { get; set; }
        public int Material_OfferDiscount { get; set; }
    }
}
