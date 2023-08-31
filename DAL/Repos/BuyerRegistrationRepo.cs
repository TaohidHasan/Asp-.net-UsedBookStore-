using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BuyerRegistrationRepo : Repo, IRepo<BuyerRegistration, int, BuyerRegistration>
    {
        public BuyerRegistration Create(BuyerRegistration obj)
        {
            db.BuyerRegistrations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public List<BuyerRegistration> Get()
        {
            return db.BuyerRegistrations.ToList();
        }

        public BuyerRegistration Get(int id)
        {
            return db.BuyerRegistrations.Find(id);
        }

        public BuyerRegistration Update(BuyerRegistration obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.BuyerRegistrations.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
    }
}
