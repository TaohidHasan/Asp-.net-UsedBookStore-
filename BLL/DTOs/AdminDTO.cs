using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminDTO
    {
        public int Id { get; set; }
        public string uname { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
