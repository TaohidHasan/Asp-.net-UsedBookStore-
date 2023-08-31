using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SellerRegistrationRepo : Repo, IRepo<SellerRegistration, int, SellerRegistration>
    {
        public SellerRegistration Create(SellerRegistration obj)
        {
            db.SellerRegistrations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
            {
                var dbobj = Get(id);
                db.SellerRegistrations.Remove(dbobj);
                return db.SaveChanges() > 0;
            }
            public List<SellerRegistration> Get()
            {
                return db.SellerRegistrations.ToList();
            }

            public SellerRegistration Get(int id)
            {
                return db.SellerRegistrations.Find(id);
            }

            public SellerRegistration Update(SellerRegistration obj)
            {
                var dbobj = Get(obj.Id);
                db.Entry(dbobj).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0) return obj;
                return null;
            }

       

      
    }
    }
