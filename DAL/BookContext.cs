using DAL.EF;
using System.Data.Entity;

namespace DAL
{
    public class BookContext : DbContext
    {
        public DbSet<SellerRegistration> SellerRegistrations { get; set; }
        public DbSet<Booklist> Booklists { get; set; }

        //public DbSet<Token> Tokens{ get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<AdminReg> adminRegs { get; set; }

        public DbSet<BuyerRegistration> BuyerRegistrations { get; set; }

        public DbSet<Inventory> Inventorys { get; set; }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
