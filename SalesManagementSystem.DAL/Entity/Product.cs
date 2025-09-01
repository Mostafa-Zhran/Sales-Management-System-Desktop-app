using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal BuyPrice  { get; set; }

        public decimal SalePrice { get; set; }

        public int CategoryId { get; set; }

        public decimal Quantity { get; set; }
    }
}
