using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    internal class ProductCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}
