using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Biography { get; set; }

        [ForeignKey("Booklist")]
        public int ListOfBooks { get; set; }
        public virtual Booklist Booklist { get; set; }

    }
}
