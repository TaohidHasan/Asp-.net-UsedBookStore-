using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AuthorRepo : Repo, IRepo<Author, int, Author>
    {


        public Author Create(Author obj)
        {
            db.Authors.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Authors.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
        public List<Author> Get()
        {
            return db.Authors.ToList();
        }

        public Author Get(int id)
        {
            return db.Authors.Find(id);
        }

        public Author Update(Author obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }


    }
}
