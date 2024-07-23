using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkCore.Models
{
 
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public SchoolContext() : base("name=SchoolDB") 
        {
        }
    }
}
