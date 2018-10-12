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
    }
}
