using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Amazon.Entities.Concrete;

namespace Amazon.DataAccess.Concrete.EntityFramework
{
    public class AmazonContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
