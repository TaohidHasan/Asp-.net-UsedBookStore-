using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Booklist
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookCondition { get; set; }
        public string Category { get; set; }
        public string Book_details { get; set; }
        public string Author_Name { get; set; }

        [ForeignKey("SellerRegistration")]
        public int SellerID { get; set; }
        public virtual SellerRegistration SellerRegistration { get; set; }

    }
}
