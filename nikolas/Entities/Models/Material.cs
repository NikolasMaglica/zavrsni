using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        [Required(ErrorMessage = "Morate unijeti naziv proizvoda")]
        public string? MaterialName { get; set; }        
        public int MaterialInStockQuantity { get; set; }
        [Required(ErrorMessage = "Morate unijeti cijenu materijala")]
        [StringLength(6, ErrorMessage = "Unos ne smije biti veci od 6 znamenki")]
        public double MaterialPrice { get; set; }
        [StringLength(256, ErrorMessage = "Unos ne smije biti veci od 256 znamenki")]
        public string? MaterialDescription { get; set; }

        public  ICollection<Order_Material>? Order_Materials { get; set; }

        public ICollection<Material_Offer>? Material_Offers { get; set; }





    }
}
