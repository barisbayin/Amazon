using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Entities.Abstract;

namespace Amazon.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Asin { get; set; }
        public string Fnsku { get; set; }
        public string Sku { get; set; }
        public string Ean { get; set; }
        public string ProductName { get; set; }
        public string BrandId { get; set; }
        public string ModelNumber { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public DateTime DateOfAdd { get; set; }
        public int IsDeleted { get; set; }
        public DateTime DateOfDeletion { get; set; }
    }
}
