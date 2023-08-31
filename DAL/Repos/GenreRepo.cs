using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GenreRepo : Repo, IRepo<Genre, int, Genre>
    {


        public Genre Create(Genre obj)
        {
            db.Genres.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Genres.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
        public List<Genre> Get()
        {
            return db.Genres.ToList();
        }

        public Genre Get(int id)
        {
            return db.Genres.Find(id);
        }

        public Genre Update(Genre obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }


    }
}
