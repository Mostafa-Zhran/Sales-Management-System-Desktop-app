using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public enum Type
    {
        Sale,
        Pruchese,
        Expensive

    }
    public class StockDetails
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int SaleOedrId { get; set; }
        public int Quantity { get; set; }

        public Type StockType { get; set; }
    }
}
