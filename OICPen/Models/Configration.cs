using System.Data.Entity.Migrations;

namespace OICPen.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<OICPenDbContext>
    {
        //自動マイグレーション機能を有効にする。
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "OICPen.Models.OICPenDbContext";
        }
    }
}
