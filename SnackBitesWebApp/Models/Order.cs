using System.ComponentModel.DataAnnotations;

namespace SnackBitesWebApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int SnackBitesWebAppUserID { get; set; }
        public int StaffID { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderStatus { get; set; }
    }
}
