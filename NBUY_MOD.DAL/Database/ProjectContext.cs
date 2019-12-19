using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using NBUY_MOD.DAL.Mappings;
using NBUY_MOD.Entities.Entity;

namespace NBUY_MOD.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        //: base("") //connectionPath
        {
            Configuration.LazyLoadingEnabled = false;
            //Database.Connection.ConnectionString = @"Server=;Database=;Uid=;Pwd=;";

            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<News> News { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CategoryMappings());
        }
    }
}