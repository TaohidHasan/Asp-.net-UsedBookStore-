using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Booklist, int, Booklist> BooklistDataAccess()
        {
            return new BooklistRepo();
        }

        public static IRepo<Inventory, int, Inventory> InventoryDataAccess()
        {
            return new InventoryRepo();
        }
        public static IRepo<SellerRegistration, int, SellerRegistration> SellerRegistrationDataAccess()
        {
            return new SellerRegistrationRepo();
        }
        public static IRepo<Event, int, Event> EventDataAccess()
        {
            return new EventRepo();
        }
        public static IRepo<Location, int, Location> LocationDataAccess()
        {
            return new LocationRepo();
        }
        public static IAdminRepo<AdminReg, int, bool> AdminDataAcccess()
        {
            return new AdminRepo();
        }
        public static IRepo<BuyerRegistration, int, BuyerRegistration> BuyerRegistrationDataAccess()
        {
            return new BuyerRegistrationRepo();
        }

        public static IRepo<Payment, int, Payment> PaymentDataAccess()
        {
            return new PaymentRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }

        public static IRepo<Author, int, Author> AuthorDataAccess()
        {
            return new AuthorRepo();
        }

        public static IRepo<Genre, int, Genre> GenreDataAccess()
        {
            return new GenreRepo();
        }
    }
}
