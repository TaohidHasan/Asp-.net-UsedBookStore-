using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public System.DateTime Date { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }

        public virtual Location Location { get; set; }



    }
}
