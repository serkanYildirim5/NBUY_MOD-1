using System.Data.Entity.Migrations;
using  NBUY_MOD.DAL.Database;

namespace NBUY_MOD.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
