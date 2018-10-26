namespace OICPen.Models
{
    using System.Data.Entity;
    public class OICPenDbContext : DbContext
    {
        public OICPenDbContext()
            : base("name = OICDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OICPenDbContext, Configuration>());
        }
        public virtual DbSet<GiveOrder> GiveOrders { get; set; }
        public virtual DbSet<GiveOrderDetail> GiveOrderDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<TakeOrder> TakeOrders { get; set; }
        public virtual DbSet<TakeOrderDetail> TakeOrderDetails { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

    }
}
