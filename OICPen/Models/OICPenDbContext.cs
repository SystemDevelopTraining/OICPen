namespace OICPen.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    class OICPenDbContext : DbContext
    {
        public OICPenDbContext()
            : base("name = OICDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OICPenDbContext, Configuration>());
        }
        public DbSet<GiveOrder> GiveOrders { get; set; }
        public DbSet<GiveOrderDetail> GiveOrderDetails { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TakeOrder> TakeOrders { get; set; }
        public DbSet<TakeOrderDetail> TakeOrderDetails { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Staff> Staffs { get; set; }

    }
}
