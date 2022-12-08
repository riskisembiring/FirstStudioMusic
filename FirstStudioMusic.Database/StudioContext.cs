using FirstStudioMusic.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudioMusic.Database
{
    public class StudioContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Owner> FieldOwners { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }

        public StudioContext(DbContextOptions<StudioContext> options) : base(options) { }
    }
}
