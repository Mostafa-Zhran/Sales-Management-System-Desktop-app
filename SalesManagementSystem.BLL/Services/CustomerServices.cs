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
    public class CustomerServices
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
            // Select Customer by ID 
            public static Customer GetCustomerByID(int ID)
            {
                DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from Customer Where ID ={ID}");
                if (dataTable.Rows.Count == 0)
                {
                    return null;
                }
                Customer Customer = new Customer();

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Customer.ID = (int)(dataRow["ID"]);
                    Customer.Name = (string)(dataRow["Name"]);
                    Customer.Email = (string)(dataRow["Email"]);
                    Customer.Phone = (string)(dataRow["Phone"]);

                }
                    return Customer;
            }

            // Add Customer
            public static bool AddCustomer(Customer Customer)
            {
                string Command = $"Insert into Employuee Values () {Customer.ID} , {Customer.Name} , {Customer.Email} , {Customer.Phone}";
                return DatabaseHelper.ExecutDML(Command);
            }

            //Update Customer
            public static bool UpdateCustomer(Customer Customer)
            {
                string Command = $"Insert into Employuee Values () {Customer.ID} , {Customer.Name} , {Customer.Email} , {Customer.Phone}";
                return DatabaseHelper.ExecutDML(Command);
            }
            //Delete Customer
            public static bool DeleteCustomer(int ID)
            {
                string Command = $"Delete from Customer Where ID =  {ID}";
                return DatabaseHelper.ExecutDML(Command);
            }
        
    }
}


