using SalesManagementSystem.DAL.Entity;
using SalesManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace SalesManagementSystem.BLL.Services
{
    public class SalesOrderProductServices
    {
        public static bool AddSaleOrderProduct (List<SaleOrderProduct> SaleProducts)
        {
          StringBuilder stringBuilder = new StringBuilder ();
            foreach (var product in SaleProducts)
            {
                stringBuilder.Append($"({product.ProductTotalPrice}, {product.SaleOrderID}, {product.ProductID}, {product.ProductPrice}, {product.ProductQuantity}),");
            }
          string sql = stringBuilder.ToString ().TrimEnd (',');

          string Command =
                    $"INSERT INTO SaleOrderProduct (ProductTotalPrice , SaleOrderID, ProductID, ProductPrice, ProductQuantity) " +
                    $"VALUES {sql}";

           return DatabaseHelper.ExecutDML(Command);  
        }
       
        
    }
}
