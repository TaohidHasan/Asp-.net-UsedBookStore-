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
    public class InventoryService
    {
        public static List<InventoryDTO> Get()
    {
        var data = DataAccessFactory.InventoryDataAccess().Get();
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Inventory, InventoryDTO>();
        });
        var mapper = new Mapper(config);
        var cnvrt = mapper.Map<List<InventoryDTO>>(data);
        return cnvrt;
    }
    public static InventoryDTO Get(int id)
    {
        var data = DataAccessFactory.InventoryDataAccess().Get(id);
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Inventory, InventoryDTO>();
        });
        var mapper = new Mapper(config);
        var cnvrt = mapper.Map<InventoryDTO>(data);
        return cnvrt;
    }
   /* public static List<InventoryDTO> Get(string Author_Name)
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
    }*/

    public static InventoryDTO Create(InventoryDTO pro)
    {
        var cfg = new MapperConfiguration(c => {
            c.CreateMap<InventoryDTO, Inventory>();
            c.CreateMap<Inventory, InventoryDTO>();
        });
        var mapper = new Mapper(cfg);
        var pr = mapper.Map<Inventory>(pro);
        var data = DataAccessFactory.InventoryDataAccess().Create(pr);

        if (data != null) return mapper.Map<InventoryDTO>(data);
        return null;
    }

    public static bool Delete(int id)
    {
        var data = DataAccessFactory.InventoryDataAccess().Delete(id);
        if (data != false) return true;
        return false;
    }

    public static InventoryDTO Update(InventoryDTO div)
    {
        var cfg = new MapperConfiguration(c => {
            c.CreateMap<InventoryDTO, Inventory>();
            c.CreateMap<Inventory, InventoryDTO>();
        });
        var mapper = new Mapper(cfg);
        var ht = mapper.Map<Inventory>(div);
        var data = DataAccessFactory.InventoryDataAccess().Update(ht);

        if (data != null) return mapper.Map<InventoryDTO>(data);
        return null;
    }

}
    }

