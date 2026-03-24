using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("StaffID")]
        public Staff Staff { get; set; }

    }
}
