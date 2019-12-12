using NBUY_MOD.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using NBUY_MOD.DAL.Mappings;

namespace NBUY_MOD.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        //: base("") //connectionPath
        {
            Configuration.LazyLoadingEnabled = false;
            //Database.Connection.ConnectionString = @"Server=;Database=;Uid=;Pwd=;";
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