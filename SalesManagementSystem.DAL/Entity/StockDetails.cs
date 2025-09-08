using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Entity
{
    public enum type
    {
        Sale =1 ,
        Pruchese =2,
        Expensive =3 ,

    }
    public class StockDetails
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int SaleOedrId { get; set; }
        public decimal Money { get; set; }

        public type StockType { get; set; }

        public DateTime DateTime { get; set; }
    }
}
