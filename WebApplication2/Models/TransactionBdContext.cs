using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TransactionBdContext : DbContext
    {
        public TransactionBdContext(DbContextOptions<TransactionBdContext> options): base(options)
        {

        }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
