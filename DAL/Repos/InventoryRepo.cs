using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class InventoryRepo : Repo, IRepo<Inventory, int, Inventory>
    {


        public Inventory Create(Inventory obj)
        {
            db.Inventorys.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Inventorys.Remove(dbobj);
            return db.SaveChanges() > 0;
        }
        public List<Inventory> Get()
        {
            return db.Inventorys.ToList();
        }

        public Inventory Get(int id)
        {
            return db.Inventorys.Find(id);
        }

        public Inventory Update(Inventory obj)
        {
            var dbobj = Get(obj.InventoryID);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }


    }
}
