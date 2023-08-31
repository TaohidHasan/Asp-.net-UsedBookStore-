using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EventRepo : Repo, IRepo<Event, int, Event>
    {


        public Event Create(Event obj)
        {
            db.Events.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Events.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
        public List<Event> Get()
        {
            return db.Events.ToList();
        }

        public Event Get(int id)
        {
            return db.Events.Find(id);
        }

        public Event Update(Event obj)
        {
            var dbobj = Get(obj.EventID);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}