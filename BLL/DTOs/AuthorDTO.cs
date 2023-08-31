using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AuthorDTO
    {

        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Biography { get; set; }
        public int ListOfBooks { get; set; }

    }
}
