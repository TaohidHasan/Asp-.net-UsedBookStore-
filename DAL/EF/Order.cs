using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("BuyerRegistration")]
        public int BuyerID { get; set; }
        [Required]
        public string DeliveryAddress { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual BuyerRegistration BuyerRegistration { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public Order()
        {
            Payments = new List<Payment>();
        }

    }
}
