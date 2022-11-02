using System.ComponentModel.DataAnnotations.Schema;

namespace nikolas.Entities.Models
{
    public class Order_Material
    {
        

        public int OrderId { get; set; }
        public Order Order { get; set; }    
        public int MaterialId { get; set; }
        public Material Material { get; set; }


        [ForeignKey("Dept")]
        public int Order_StatusId { get; set; }
        public virtual Order_Status Order_Statuses { get; set; }

        public int Order_MaterialQuantity { get; set; }
    }
}
