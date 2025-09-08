using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public class SaleOrderProduct
    {
        public int ID { get; set; }
        public decimal ProductPrice  { get; set; }
        public decimal ProductQuantity { get; set; }

        public decimal ProductTotalPrice { get; set; }

        public int SaleOrderID  { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }



    }
}
