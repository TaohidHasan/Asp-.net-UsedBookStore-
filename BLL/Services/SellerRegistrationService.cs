using AutoMapper;
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
    public class SellerRegistrationService
    {
        public static List<SellerRegistrationDTO> Get()
        {
            var data = DataAccessFactory.SellerRegistrationDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SellerRegistration, SellerRegistrationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<SellerRegistrationDTO>>(data);
            return cnvrt;
        }
        public static SellerRegistrationDTO Get(int id)
        {
            var data = DataAccessFactory.SellerRegistrationDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SellerRegistration, SellerRegistrationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<SellerRegistrationDTO>(data);
            return cnvrt;
        }
   

        public static SellerRegistrationDTO Create(SellerRegistrationDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<SellerRegistrationDTO, SellerRegistration>();
                c.CreateMap<SellerRegistration, SellerRegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<SellerRegistration>(pro);
            var data = DataAccessFactory.SellerRegistrationDataAccess().Create(pr);

            if (data != null) return mapper.Map<SellerRegistrationDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.SellerRegistrationDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static SellerRegistrationDTO Update(SellerRegistrationDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<SellerRegistrationDTO, SellerRegistration>();
                c.CreateMap<SellerRegistration, SellerRegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<SellerRegistration>(div);
            var data = DataAccessFactory.SellerRegistrationDataAccess().Update(ht);

            if (data != null) return mapper.Map<SellerRegistrationDTO>(data);
            return null;
        }
    }
}
