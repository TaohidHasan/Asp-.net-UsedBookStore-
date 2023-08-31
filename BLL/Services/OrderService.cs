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
    public class OrderService
    {
        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<OrderDTO>>(data);
            return cnvrt;
        }

        public static OrderDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<OrderDTO>(data);
            return cnvrt;
        }

        public static OrderDTO Create(OrderDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<OrderDTO, Order>();
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Order>(pro);
            var data = DataAccessFactory.OrderDataAccess().Create(pr);

            if (data != null) return mapper.Map<OrderDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.OrderDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static OrderDTO Update(OrderDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<OrderDTO, Order>();
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Order>(div);
            var data = DataAccessFactory.OrderDataAccess().Update(ht);

            if (data != null) return mapper.Map<OrderDTO>(data);
            return null;
        }
    }
}
