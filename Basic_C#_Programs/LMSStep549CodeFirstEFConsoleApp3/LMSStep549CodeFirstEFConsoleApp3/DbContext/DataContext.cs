using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LMSStep549CodeFirstEFConsoleApp3
{
    public class DataContext : DbContext
    {
        public DataContext( ) : base()
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<EstudiantePermission> EstudiantePermissions { get; set; }

    }
}
