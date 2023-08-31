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
    public class BooklistService
    {
        public static List<BooklistDTO> Get()
        {
            var data = DataAccessFactory.BooklistDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<BooklistDTO>>(data);
            return cnvrt;
        }
        public static BooklistDTO Get(int id)
        {
            var data = DataAccessFactory.BooklistDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<BooklistDTO>(data);
            return cnvrt;
        }
        public static List<BooklistDTO> Get(string Author_Name)
        {
            var data = (from n in DataAccessFactory.BooklistDataAccess().Get()
                        where n.Author_Name.ToLower().Contains(Author_Name.ToLower())
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<BooklistDTO>>(data);
            return cnvrt;
        }

        public static List<BooklistDTO> GetCategory(string cat)
        {
            var data = (from n in DataAccessFactory.BooklistDataAccess().Get()
                        where n.Category.ToLower().Contains(cat.ToLower())
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<BooklistDTO>>(data);
            return cnvrt;
        }

        public static BooklistDTO Create(BooklistDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BooklistDTO, Booklist>();
                c.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Booklist>(pro);
            var data = DataAccessFactory.BooklistDataAccess().Create(pr);

            if (data != null) return mapper.Map<BooklistDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.BooklistDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

        public static BooklistDTO Update(BooklistDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BooklistDTO, Booklist>();
                c.CreateMap<Booklist, BooklistDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Booklist>(div);
            var data = DataAccessFactory.BooklistDataAccess().Update(ht);

            if (data != null) return mapper.Map<BooklistDTO>(data);
            return null;
        }
      
    }
}
