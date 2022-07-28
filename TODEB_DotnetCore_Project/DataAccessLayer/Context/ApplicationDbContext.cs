using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete;

namespace DataAccessLayer.Context
{
    public class ApplicationDbContext : DbContext
    {
        private IConfiguration _configuration;

        public ApplicationDbContext (IConfiguration configuration )
	    {
            _configuration = configuration;
	    }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConntectionString("MsComm");
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
        }
    }
}
