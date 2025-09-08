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
    public class Customerservices
    {
        
            //Select All Customer 
            public static List<Customer> GetAllCustomers()
            {
                DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from Customer");
                List<Customer> Customers = new List<Customer>();

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Customer Customer = new Customer();
                    Customer.ID = (int)(dataRow["ID"]);
                    Customer.Name = (string)(dataRow["Name"]);
                    Customer.Email = (string)(dataRow["Email"]);
                    Customer.Phone = (string)(dataRow["Phone"]);
                    Customers.Add(Customer);
                }
                return Customers;
            }
            // Select Customer by Pattern 
            public static List<Customer> GetCustomerByPattern(string Pattern)
            {
                DataTable dataTable = DatabaseHelper.ExecuteQuery($"SELECT * FROM Customer WHERE Name LIKE N'%{Pattern}%'" +
                    $" OR Email LIKE N'%{Pattern}%'" +
                     $"OR Phone LIKE N'%{Pattern}%'");

                if (dataTable.Rows.Count == 0)
                {
                    return null;
                }

                List<Customer> Customers = new List<Customer>();


                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Customer Customer = new Customer();
                    Customer.ID = (int)(dataRow["ID"]);
                    Customer.Name = (string)(dataRow["Name"]);
                    Customer.Email = (string)(dataRow["Email"]);
                    Customer.Phone = (string)(dataRow["Phone"]);
                    Customers.Add(Customer);

                }
                    return Customers;
            }

            // Add Customer
            public static bool AddCustomer(Customer Customer)
            {
                string Command = $"INSERT INTO Customer (Name, Email, Phone) " +
                                    $"VALUES (N'{Customer.Name}', N'{Customer.Email}', N'{Customer.Phone}')";
            return DatabaseHelper.ExecutDML(Command);
            }

            //Update Customer
            public static bool UpdateCustomer(Customer Customer)
            {
                string Command = $"Update  Customer Set Name = N'{Customer.Name}' , Email = N'{Customer.Email}' , Phone = N'{Customer.Phone}' Where ID =  {Customer.ID}";
                return DatabaseHelper.ExecutDML(Command);
            }
            //Delete Customer
            public static bool DeleteCustomer(int ID)
            {
                string Command = $"Delete from Customer Where ID =  {ID}";
                return DatabaseHelper.ExecutDML(Command);
            }

        //Delete Customer
        public static bool DeleteAllCustomer()
        {
            string Command = $"Delete from Customer ";
            return DatabaseHelper.ExecutDML(Command);
        }

    }
}


