using Ef_CodeFirst_Proj4.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst_Proj4.DAL.Context
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
