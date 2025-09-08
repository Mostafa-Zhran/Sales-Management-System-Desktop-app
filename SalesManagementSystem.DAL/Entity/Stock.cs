using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public class Stock
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public decimal Money { get; set; }
    }
}
