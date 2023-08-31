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
    public class EventService
    {
        public static List<EventDTO> Get()
        {
            var data = DataAccessFactory.EventDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<EventDTO>>(data);
            return cnvrt;
        }
        public static EventDTO Get(int id)
        {
            var data = DataAccessFactory.EventDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<EventDTO>(data);
            return cnvrt;
        }
 

        public static EventDTO Create(EventDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<EventDTO, Event>();
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Event>(pro);
            var data = DataAccessFactory.EventDataAccess().Create(pr);

            if (data != null) return mapper.Map<EventDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.EventDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static EventDTO Update(EventDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<EventDTO, Event>();
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Event>(div);
            var data = DataAccessFactory.EventDataAccess().Update(ht);

            if (data != null) return mapper.Map<EventDTO>(data);
            return null;
        }

        public static List<EventDTO> GetByAddressDate(string cat, DateTime date)
        {
            var data = (from n in DataAccessFactory.EventDataAccess().Get()
                        where n.Location.Address.ToLower().Contains(cat.ToLower())
                        && n.Date == date
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<EventDTO>>(data);
            return cnvrt;
        }

    }
}
