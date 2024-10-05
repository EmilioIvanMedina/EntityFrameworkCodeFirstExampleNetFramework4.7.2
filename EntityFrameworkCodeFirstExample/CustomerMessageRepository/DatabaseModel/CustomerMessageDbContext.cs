using CustomerMessageRepository.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CustomerMessageRepository.DatabaseModel
{
    public class CustomerMessageDbContext : DbContext
    {
        public DbSet<CustomerMessage> CustomerMessages { get; set; }

        public CustomerMessageDbContext() : base("name=CustomerMessageDbConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerMessage>()
                .HasKey(cm => cm.IdCustomerMessage)
                .Property(cm => cm.IdCustomerMessage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }
    }
}
