using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.EF
{
    public class SellerRegistration
    {
        public int Id { get; set; }
        [Required]

        public string uname { get; set; }
        public string gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string phone { get; set; }
        public string user_type { get; set; }
        public string shop_name { get; set; }
        public string password { get; set; }

        public virtual ICollection<Booklist> Booklists { get; set; }        
        public SellerRegistration()
        {

            Booklists = new List<Booklist>();
        }

    }
}
