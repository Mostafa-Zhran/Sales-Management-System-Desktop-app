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
    public class SalesOrderServices
    {
        public static List<SaleOrder> GetAllSaleOrders()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from SaleOrder");
            List<SaleOrder> SaleOrders = new List<SaleOrder>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                SaleOrder SaleOrder = new SaleOrder();
                SaleOrder.ID = (int)(dataRow["ID"]);
                SaleOrder.CustomerId = (int)(dataRow["CustomerID"]);
                SaleOrder.OrderDate = (DateTime)(dataRow["OrderDate"]);
                SaleOrder.TotalOrder = (decimal)(dataRow["TotalOrder"]);
                SaleOrders.Add(SaleOrder);
            }
            return SaleOrders;
        }

        //Get Customer Orders
        public static List<CustomerOrder> GetAllCustomerOrders()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from SaleOrder");
            List<CustomerOrder> CustomerOrders = new List<CustomerOrder>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                CustomerOrder CSO = new CustomerOrder();
                CSO.CustomerId = (int)(dataRow["ID"]);
                CSO.Name = (string)(dataRow["CustomerID"]);
                CSO.Phone = (string)(dataRow["OrderDate"]);
                CSO.OrderDate = (DateTime)(dataRow["TotalOrder"]);
                CSO.TotalOrder = (decimal)(dataRow["OrderDate"]);
                CustomerOrders.Add(CSO);
            }
            return CustomerOrders;
        }
        // Select SaleOrder by ID 
        public static SaleOrder GetSaleOrderByID(int ID)
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from SaleOrder Where ID ={ID}");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            SaleOrder SaleOrder = new SaleOrder();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                SaleOrder.ID = (int)(dataRow["ID"]);
                SaleOrder.CustomerId = (int)(dataRow["CustomerID"]);
                SaleOrder.OrderDate = (DateTime)(dataRow["OrderDate"]);
                SaleOrder.TotalOrder = (decimal)(dataRow["TotalOrder"]);

            }
            return SaleOrder;
        }

        // Add SaleOrder
        public static bool AddSaleOrder(SaleOrder SaleOrder)
        {
            string Command = $"Insert into Employuee Values () {SaleOrder.ID} , {SaleOrder.CustomerId} , {SaleOrder.OrderDate} , {SaleOrder.TotalOrder}";
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

    }
}
