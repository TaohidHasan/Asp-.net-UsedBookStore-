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
    public class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory.PaymentDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<PaymentDTO>>(data);
            return cnvrt;
        }
        public static PaymentDTO Get(int id)
        {
            var data = DataAccessFactory.PaymentDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<PaymentDTO>(data);
            return cnvrt;
        }
        public static PaymentDTO Create(PaymentDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PaymentDTO, Payment>();
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Payment>(pro);
            var data = DataAccessFactory.PaymentDataAccess().Create(pr);

            if (data != null) return mapper.Map<PaymentDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.PaymentDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static PaymentDTO Update(PaymentDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PaymentDTO, Payment>();
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Payment>(div);
            var data = DataAccessFactory.PaymentDataAccess().Update(ht);

            if (data != null) return mapper.Map<PaymentDTO>(data);
            return null;
        }
    }
}
