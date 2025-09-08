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
    public class Productservices
    {
        public static List<Product> GetAllProducts()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from Product");
            List<Product> Products = new List<Product>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Product Product = new Product();
                Product.ID = (int)(dataRow["ID"]);
                Product.Name = (string)(dataRow["Name"]);
                Product.BuyPrice = (decimal)(dataRow["BuyPrice"]);
                Product.SalePrice = (decimal)(dataRow["SalePrice"]);
                Product.CategoryId = (int)(dataRow["CategoryID"]);
                Product.Quantity = (decimal)(dataRow["Quantity"]);
                Products.Add(Product);
            }
            return Products;
        }
        //Get Product bu Id
        public static Product GetProductbyId(int ID)
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from Product Where ID = {ID}");
            Product Product = new Product();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Product.ID = (int)(dataRow["ID"]);
                Product.Name = (string)(dataRow["Name"]);
                Product.BuyPrice = (decimal)(dataRow["BuyPrice"]);
                Product.SalePrice = (decimal)(dataRow["SalePrice"]);
                Product.CategoryId = (int)(dataRow["CategoryID"]);
                Product.Quantity = (decimal)(dataRow["Quantity"]);
            }
            return Product;
        }
        // Select Product by Pattern
        public static List<Product>  GetProductByPattern(string Pattern)
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from Product Where Name like N'%{Pattern}%' or BuyPrice like N'%{Pattern}%' or SalePrice like N'%{Pattern}%'");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            List<Product> Products = new List<Product>();


            foreach (DataRow dataRow in dataTable.Rows)
            {
                Product Product = new Product();
                Product.ID = (int)(dataRow["ID"]);
                Product.Name = (string)(dataRow["Name"]);
                Product.BuyPrice = (decimal)(dataRow["BuyPrice"]);
                Product.SalePrice = (decimal)(dataRow["SalePrice"]);
                Product.CategoryId = (int)(dataRow["CategoryID"]);
                Product.Quantity = (decimal)(dataRow["Quantity"]);
                Products.Add(Product);
            }
            return Products;
        }

        // Add Product
        public static bool AddProduct(Product Product)
        {
            string Command = $"INSERT INTO Product (Name, BuyPrice, SalePrice, CategoryID ,Quantity )VALUES (N'{Product.Name}', {Product.BuyPrice}, {Product.SalePrice}, {Product.CategoryId} ,{Product.Quantity} );";
            return DatabaseHelper.ExecutDML(Command);
        }

        //Update Product
        public static bool UpdateProduct(Product Product)
        {
            string Command = $"Update Product Set Name  = N'{Product.Name}' , BuyPrice =  {Product.BuyPrice} ,SalePrice =  {Product.SalePrice} , CategoryID =  {Product.CategoryId} , [Quantity] = {Product.Quantity} Where ID =  {Product.ID}" +
                $"";
            return DatabaseHelper.ExecutDML(Command);
        }
        //Delete Product
        public static bool DeleteProduct(int ID)
        {
            string Command = $"Delete from Product Where ID =  {ID}";
            return DatabaseHelper.ExecutDML(Command);
        }

        public static bool DeleteAllProduct()
        {
            string Command = $"Delete from Product";
            return DatabaseHelper.ExecutDML(Command);
        }

        public static bool UpdateProductAfterSale(List<Product> Products)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var Product in Products)
            {
                sb.Append($"Update Product Set [Quantity] = [Quantity] - {Product.Quantity} where ID = {Product.ID} ;");
            }
            string Command = sb.ToString();

            return DatabaseHelper.ExecutDML(Command);
        }

    }
}
