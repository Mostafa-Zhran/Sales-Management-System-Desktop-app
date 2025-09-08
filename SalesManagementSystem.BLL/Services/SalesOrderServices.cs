using SalesManagementSystem.DAL;
using SalesManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.BLL.Services
{
    public class SalesOrderservices
    {        // Add SaleOrder
        public static bool AddSaleOrder(SaleOrder SaleOrder)
        {
            string Command =
                $"INSERT INTO SaleOrder (CustomerID, OrderDate, TotalOrder) " +
                $"VALUES ({SaleOrder.CustomerId}, '{SaleOrder.OrderDate:yyyy-MM-dd}', {SaleOrder.TotalOrder});";
            return DatabaseHelper.ExecutDML(Command);
        }

        //Update SaleOrder
        public static bool UpdateSaleOrder(SaleOrder SaleOrder)
        {
            string Command = $"Insert into Employuee Values () {SaleOrder.ID} , {SaleOrder.CustomerId} , {SaleOrder.OrderDate} , {SaleOrder.TotalOrder}";
            return DatabaseHelper.ExecutDML(Command);
        }
        //Delete SaleOrder
        public static bool DeleteSaleOrder(int ID)
        {
            string Command = $"Delete from SaleOrder Where ID =  {ID}";
            return DatabaseHelper.ExecutDML(Command);
        }

        public static int GetlastOrderID()
        {
            string Command = "select IsNuLl(Max(ID),0) as LastId from [dbo].[SaleOrder]";
            var dataTable = DatabaseHelper.ExecuteQuery(Command);
            var Row = dataTable.Rows[0];
            return (int)Row["LastId"];
        }
    }
}
