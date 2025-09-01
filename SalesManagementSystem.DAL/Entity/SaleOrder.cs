using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public class SaleOrder
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalOrder { get; set; }
    }
}
