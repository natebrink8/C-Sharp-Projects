using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSStep549CodeFirstEFConsoleApp3
{
    public class Estudiante
    {
        public string FirstName { get; set; }

        [Key]
        public int Id { get; set; }

    }
}
