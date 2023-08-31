using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{ 
     internal class LocationRepo : Repo, IRepo<Location, int, Location>
    {


        public Location Create(Location obj)
        {
            db.Locations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Locations.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
        public List<Location> Get()
        {
            return db.Locations.ToList();
        }

        public Location Get(int id)
        {
            return db.Locations.Find(id);
        }

        public Location Update(Location obj)
        {
            var dbobj = Get(obj.ID);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
