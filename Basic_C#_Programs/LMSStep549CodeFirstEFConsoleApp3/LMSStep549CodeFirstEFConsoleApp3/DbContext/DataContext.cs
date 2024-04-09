using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LMSStep549CodeFirstEFConsoleApp3.DbModels
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base(connectionString)
        {

        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; }

        public virtual DbSet<EstudiantePermission> EstudiantePermissions { get; set; }

    }
}
