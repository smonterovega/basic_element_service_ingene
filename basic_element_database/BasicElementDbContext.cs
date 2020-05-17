using basic_element_database.Elements;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_element_database
{
    public class BasicElementDbContext : DbContext
    {
        public DbSet<Element> Elements;
    }
}
