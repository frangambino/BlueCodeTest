using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer
{
    public class BluecodeDbContext:DbContext
    {
        public BluecodeDbContext():base("DefaultConnection")
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
