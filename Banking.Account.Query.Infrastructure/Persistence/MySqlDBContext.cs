using Banking.Account.Query.Domain;
using Microsoft.EntityFrameworkCore;

namespace Banking.Account.Query.Infrastructure.Persistence
{
    public class MySqlDBContext : DbContext
    {
        public MySqlDBContext(DbContextOptions<MySqlDBContext> options) : base(options) 
        { }

        public DbSet<BankAccount>? BankAccounts { get; set; }
    }
}
