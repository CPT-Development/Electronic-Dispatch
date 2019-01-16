using ED.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED.DATA
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
