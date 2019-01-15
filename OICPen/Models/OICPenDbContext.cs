namespace OICPen.Models
{
    using System.Data.Entity;
    public class OICPenDbContext : DbContext
    {
        public OICPenDbContext()
            : base("name = OICPenDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OICPenDbContext, Configuration>());
        }
        public virtual DbSet<GiveOrderT> GiveOrders { get; set; }
        public virtual DbSet<GiveOrderDetailT> GiveOrderDetails { get; set; }
        public virtual DbSet<ClientT> Clients { get; set; }
        public virtual DbSet<TakeOrderT> TakeOrders { get; set; }
        public virtual DbSet<TakeOrderDetailT> TakeOrderDetails { get; set; }
        public virtual DbSet<ItemT> Items { get; set; }
        public virtual DbSet<StaffT> Staffs { get; set; }

    }
}
