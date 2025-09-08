using SalesManagementSystem.DAL.Entity;
using SalesManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.BLL.Services
{
    public class CustomerOrdersServices
    {
        public static List<CustomerOrder> GetCustomerOrderByPattern(string pattern)
        {
            List<CustomerOrder> CustomerOrders = new List<CustomerOrder>();

            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from v_CustomerOrders_Summarized Where Name like N'%{pattern}%'");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow dataRow in dataTable.Rows)
            {
                CustomerOrder order = new CustomerOrder();

                order.CustomerID = Convert.ToInt32(dataRow["CustomerID"]);
                order.CustomerName = Convert.ToString(dataRow["CustomerName"]);
                order.SaleOrderID = Convert.ToInt32(dataRow["SaleOrderID"]);
                order.OrderDate = Convert.ToDateTime(dataRow["OrderDate"]);
                order.OrderTotalPrice = Convert.ToDecimal(dataRow["OrderTotalPrice"]);
                order.ProductName = Convert.ToString(dataRow["ProductName"]);
                order.ProductQuantity = Convert.ToDecimal(dataRow["ProductQuantity"]);
                order.ProductPrice = Convert.ToDecimal(dataRow["ProductPrice"]);
                order.ProductTotalPrice = Convert.ToDecimal(dataRow["ProductTotalPrice"]);

                CustomerOrders.Add(order);
            }
            return CustomerOrders;
        }

        public static List<CustomerOrder> GetAllCutomerOrder()
        {
            List<CustomerOrder> CustomerOrders = new List<CustomerOrder>();

            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from v_CustomerOrders_Summarized");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow dataRow in dataTable.Rows)
            {
                CustomerOrder order = new CustomerOrder();

                order.CustomerID = Convert.ToInt32(dataRow["CustomerID"]);
                order.CustomerName = Convert.ToString(dataRow["CustomerName"]);
                order.ProductID = Convert.ToInt32(dataRow["ProductID"]);
                order.SaleOrderID = Convert.ToInt32(dataRow["SaleOrderID"]);
                order.OrderDate = Convert.ToDateTime(dataRow["OrderDate"]);
                order.OrderTotalPrice = Convert.ToDecimal(dataRow["OrderTotalPrice"]);
                order.ProductName = Convert.ToString(dataRow["ProductName"]);
                order.ProductQuantity = Convert.ToDecimal(dataRow["ProductQuantity"]);
                order.ProductPrice = Convert.ToDecimal(dataRow["ProductPrice"]);
                order.ProductTotalPrice = Convert.ToDecimal(dataRow["ProductTotalPrice"]);

                CustomerOrders.Add(order);
            }
            return CustomerOrders;
        }
    }
}
