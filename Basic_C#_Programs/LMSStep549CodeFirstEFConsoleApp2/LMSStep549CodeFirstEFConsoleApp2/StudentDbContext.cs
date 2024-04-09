using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LMSStep549CodeFirstEFConsoleApp2
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Students> Student { get; set; }
    }
}
