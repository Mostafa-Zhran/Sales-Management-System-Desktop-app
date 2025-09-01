using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public class CustomerOrder
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal TotalOrder { get; set; }


    }
}
