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
    public class GenreService
    {
        public static List<GenreDTO> Get()
        {
            var data = DataAccessFactory.GenreDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Genre, GenreDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<GenreDTO>>(data);
            return cnvrt;
        }
        public static GenreDTO Get(int id)
        {
            var data = DataAccessFactory.GenreDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Genre, GenreDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<GenreDTO>(data);
            return cnvrt;
        }


        public static GenreDTO Create(GenreDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GenreDTO, Genre>();
                c.CreateMap<Genre, GenreDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Genre>(pro);
            var data = DataAccessFactory.GenreDataAccess().Create(pr);

            if (data != null) return mapper.Map<GenreDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GenreDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static GenreDTO Update(GenreDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GenreDTO, Genre>();
                c.CreateMap<Genre, GenreDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Genre>(div);
            var data = DataAccessFactory.GenreDataAccess().Update(ht);

            if (data != null) return mapper.Map<GenreDTO>(data);
            return null;
        }

    }
}
