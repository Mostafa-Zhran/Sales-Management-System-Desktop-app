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
    public class SaledOrderProductServices
    {
        //Select All SaleOrderProduct 
        public static List<SaleOrderProduct> GetAllSaleOrderProducts()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from SaleOrderProduct");
            List<SaleOrderProduct> SaleOrderProducts = new List<SaleOrderProduct>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                SaleOrderProduct SaleOrderProduct = new SaleOrderProduct();
                SaleOrderProduct.ID = (int)(dataRow["ID"]);
                SaleOrderProduct.ProductPrice = (decimal)(dataRow["ProductPrice"]);
                SaleOrderProduct.ProductQuantity = (int)(dataRow["Email"]);
                SaleOrderProduct.ProductTotalPrice = (int)(dataRow["ProductTotalPrice"]);
                SaleOrderProduct.SaleOrderID = (int)(dataRow["SaleOrderID"]);
                SaleOrderProduct.ProductID = (int)(dataRow["ProductID"]);
                SaleOrderProducts.Add(SaleOrderProduct);
            }
            return SaleOrderProducts;
        }
        // Select SaleOrderProduct by ID 
        public static SaleOrderProduct GetSaleOrderProductByID(int ID)
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from SaleOrderProduct Where ID ={ID}");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            SaleOrderProduct SaleOrderProduct = new SaleOrderProduct();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                SaleOrderProduct SaleOrderProduct1 = new SaleOrderProduct();
                SaleOrderProduct1.ID = (int)(dataRow["ID"]);
                SaleOrderProduct1.ProductPrice = (decimal)(dataRow["ProductPrice"]);
                SaleOrderProduct1.ProductQuantity = (int)(dataRow["ProductQuantity"]);
                SaleOrderProduct1.ProductTotalPrice = (int)(dataRow["ProductTotalPrice"]);
                SaleOrderProduct1.SaleOrderID = (int)(dataRow["SaleOrderID"]);
                SaleOrderProduct1.ProductID = (int)(dataRow["ProductID"]);

            }
            return SaleOrderProduct;
        }

     
    }
}
