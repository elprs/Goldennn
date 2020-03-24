using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goldennn.Entities;

namespace Goldennn.Database
{
   public class MyDatabase : DbContext
    {

        public MyDatabase() : base("Sindesmos")
        {
                
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
