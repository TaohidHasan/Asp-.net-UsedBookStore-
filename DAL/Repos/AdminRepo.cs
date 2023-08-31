using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IAdminRepo<AdminReg, int, bool>
    {
        public List<AdminReg> Get()
        {
            return db.adminRegs.ToList();
        }

        public AdminReg Get(int id)
        {
            return db.adminRegs.Find(id);
        }

        public bool Insert(AdminReg obj)
        {
            db.adminRegs.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(AdminReg obj)
        {
            var admin = Get(obj.Id);
            obj.email = admin.email;
            obj.password = admin.password;
            obj.gender = admin.gender;
            obj.phone = admin.phone;
            obj.uname = admin.uname;
            db.Entry(admin).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var admin = Get(id);
            db.adminRegs.Remove(admin);
            return db.SaveChanges() > 0;
        }
    }
}
