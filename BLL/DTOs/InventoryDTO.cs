using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class InventoryDTO
    {
        public int InventoryID { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }
        public int BookID { get; set; }
    }
}
