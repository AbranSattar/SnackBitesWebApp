namespace SnackBitesWebApp.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int FoodID { get; set; } 
        public int Quantity { get; set; }
    }
}
