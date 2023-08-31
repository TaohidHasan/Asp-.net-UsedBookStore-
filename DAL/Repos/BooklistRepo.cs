using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BooklistRepo : Repo, IRepo<Booklist, int, Booklist>
    {
        

        public Booklist Create(Booklist obj)
        {
            db.Booklists.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Booklists.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
        public List<Booklist> Get()
        {
            return db.Booklists.ToList();
        }

        public Booklist Get(int id)
        {
            return db.Booklists.Find(id);
        }

        public Booklist Update(Booklist obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        
    }
}
