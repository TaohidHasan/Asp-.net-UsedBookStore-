using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }


    }
}