using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class AdminReg
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string uname { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string email { get; set; }



    }
}
