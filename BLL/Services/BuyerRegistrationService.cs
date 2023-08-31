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
    public class BuyerRegistrationService
    {
        public static List<BuyerRegistrationDTO> Get()
        {
            var data = DataAccessFactory.BuyerRegistrationDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BuyerRegistration, BuyerRegistrationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<BuyerRegistrationDTO>>(data);
            return cnvrt;
        }

        public static BuyerRegistrationDTO Get(int id)
        {
            var data = DataAccessFactory.BuyerRegistrationDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BuyerRegistration, BuyerRegistrationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<BuyerRegistrationDTO>(data);
            return cnvrt;
        }

        public static BuyerRegistrationDTO Create(BuyerRegistrationDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BuyerRegistrationDTO, BuyerRegistration>();
                c.CreateMap<BuyerRegistration, BuyerRegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<BuyerRegistration>(pro);
            var data = DataAccessFactory.BuyerRegistrationDataAccess().Create(pr);

            if (data != null) return mapper.Map<BuyerRegistrationDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.BuyerRegistrationDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static BuyerRegistrationDTO Update(BuyerRegistrationDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BuyerRegistrationDTO, BuyerRegistration>();
                c.CreateMap<BuyerRegistration, BuyerRegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<BuyerRegistration>(div);
            var data = DataAccessFactory.BuyerRegistrationDataAccess().Update(ht);

            if (data != null) return mapper.Map<BuyerRegistrationDTO>(data);
            return null;
        }
        public static List<BooklistDTO> GetBooks()
        {
            var data = DataAccessFactory.BooklistDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<BooklistDTO>>(data);
            return cnvrt;
        }

    }
}
