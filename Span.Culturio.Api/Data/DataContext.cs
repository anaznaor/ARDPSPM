using Span.Culturio.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Span.Culturio.Api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CultureObject> CultureObjects { get; set; }
        public DbSet<Package> Package { get; set; }
        //public DbSet<PackageCultureObject> PackageCultureObject { get; set; }
        //public DbSet<RecordedVisits> RecordedVisits { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //SeedData.CreateData(modelBuilder);
        }
    }
}
