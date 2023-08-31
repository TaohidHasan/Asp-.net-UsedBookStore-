using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            return Convert(DataAccessFactory.AdminDataAcccess().Get());
        }
        public static AdminDTO Get(int id)
        {
            return Convert(DataAccessFactory.AdminDataAcccess().Get(id));
        }
        public static bool Create(AdminDTO admin)
        {
            return DataAccessFactory.AdminDataAcccess().Insert(Convert(admin));
        }

        public static bool Update(AdminDTO admin)
        {
            return DataAccessFactory.AdminDataAcccess().Update(Convert(admin));
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminDataAcccess().Delete(id);
        }
        public static bool DeleteSeller(int id)
        {
            return DataAccessFactory.SellerRegistrationDataAccess().Delete(id);
        }
        public static List<SellerRegistration> GetSeller()
        {
            return DataAccessFactory.SellerRegistrationDataAccess().Get();
        }
        static List<AdminDTO> Convert(List<AdminReg> users)
        {
            var data = new List<AdminDTO>();
            foreach (AdminReg admin in users)
            {
                data.Add(Convert(admin));
            }
            return data;
        }
        static AdminDTO Convert(AdminReg admin)
        {
            return new AdminDTO()
            {
                Id = admin.Id,
                uname = admin.uname,
                gender = admin.gender,
                email = admin.email,
                password = admin.password,
                phone = admin.phone
            };
        }
        static AdminReg Convert(AdminDTO admin)
        {
            return new AdminReg()
            {
                Id = admin.Id,
                uname = admin.uname,
                gender = admin.gender,
                email = admin.email,
                password = admin.password,
                phone = admin.phone
            };
        }
    }
}
