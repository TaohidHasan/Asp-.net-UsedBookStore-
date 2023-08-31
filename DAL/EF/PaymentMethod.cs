using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string pay_method { get; set; }
        public string amount { get; set; }

        [ForeignKey("BuyerRegistration")]
        public int BuyerID { get; set; }
        public virtual BuyerRegistration BuyerRegistration { get; set; }
    }
}
