using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities.Storage;

namespace Nozom.Data.Entities
{
    public class WrshaDbContext : DbContext
    {
        public static string connections = @"Data Source=127.0.0.1;Initial Catalog=WrshaDb;User Id=sa;Password=Gamp1234";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(connections);
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Daraga> Daragat { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceTransaction> DeviceTransactions { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ItemTransaction> ItemTransactions { get; set; }
    }
}
