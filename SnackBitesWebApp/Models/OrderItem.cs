using System.ComponentModel.DataAnnotations.Schema;

namespace SnackBitesWebApp.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int FoodID { get; set; } 
        public int Quantity { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [ForeignKey("FoodID")]
        public Food Food { get; set; }
    }
}
