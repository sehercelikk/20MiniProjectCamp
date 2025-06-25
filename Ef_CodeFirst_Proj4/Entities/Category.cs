using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst_Proj4.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
