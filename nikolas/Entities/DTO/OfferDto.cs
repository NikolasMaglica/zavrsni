namespace nikolas.Entities.DTO
{
    public class OfferDto
    {
        public int id { get; set; } 
        public int ClientId { get; set; }

        public int UserId { get; set; }

        public int VehicleId { get; set; }

        public int Offer_StatusID { get; set; }
        public int price { get; set; }

        public IEnumerable<Material_OfferDto> Material_Offers { get; set; }
        public IEnumerable<Service_OfferDto> Service_Offers { get; set; }

    }
}
