using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EventDTO
    {

        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public System.DateTime Date { get; set; }
        public int LocationID { get; set; }

    }
}
