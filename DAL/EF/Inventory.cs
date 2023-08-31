using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }

        [ForeignKey("Booklist")]
        public int BookID { get; set; }
        public virtual Booklist Booklist { get; set; }
    }
}
