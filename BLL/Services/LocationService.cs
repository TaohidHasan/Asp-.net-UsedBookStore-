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
    public class LocationService
    {
        public static List<LocationDTO> Get()
        {
            var data = DataAccessFactory.LocationDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Location, LocationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<LocationDTO>>(data);
            return cnvrt;
        }
        public static LocationDTO Get(int id)
        {
            var data = DataAccessFactory.LocationDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Location, LocationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<LocationDTO>(data);
            return cnvrt;
        }


        public static LocationDTO Create(LocationDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<LocationDTO, Location>();
                c.CreateMap<Location, LocationDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Location>(pro);
            var data = DataAccessFactory.LocationDataAccess().Create(pr);

            if (data != null) return mapper.Map<LocationDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.LocationDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static LocationDTO Update(LocationDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<LocationDTO, Location>();
                c.CreateMap<Location, LocationDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Location>(div);
            var data = DataAccessFactory.LocationDataAccess().Update(ht);

            if (data != null) return mapper.Map<LocationDTO>(data);
            return null;
        }

    }
}
