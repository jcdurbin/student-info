using Netchemia.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// only needed when working with database
namespace Netchemia.Data
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public DbSet<Student> Students { get; set; }
    }
}
