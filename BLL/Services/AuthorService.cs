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
    public class AuthorService
    {
        public static List<AuthorDTO> Get()
        {
            var data = DataAccessFactory.AuthorDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Author, AuthorDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<AuthorDTO>>(data);
            return cnvrt;
        }
        public static AuthorDTO Get(int id)
        {
            var data = DataAccessFactory.AuthorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Author, AuthorDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<AuthorDTO>(data);
            return cnvrt;
        }


        public static AuthorDTO Create(AuthorDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AuthorDTO, Author>();
                c.CreateMap<Author, AuthorDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Author>(pro);
            var data = DataAccessFactory.AuthorDataAccess().Create(pr);

            if (data != null) return mapper.Map<AuthorDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.AuthorDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static AuthorDTO Update(AuthorDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AuthorDTO, Author>();
                c.CreateMap<Author, AuthorDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Author>(div);
            var data = DataAccessFactory.AuthorDataAccess().Update(ht);

            if (data != null) return mapper.Map<AuthorDTO>(data);
            return null;
        }

    }
}
