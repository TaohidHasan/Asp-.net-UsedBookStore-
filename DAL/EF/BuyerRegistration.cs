using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class BuyerRegistration
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string phone { get; set; }
        public string user_type { get; set; }
        public string password { get; set; }
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
