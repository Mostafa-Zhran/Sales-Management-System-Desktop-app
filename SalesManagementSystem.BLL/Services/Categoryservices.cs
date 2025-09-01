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
    public class Categoryservices
    {
        public static List<Category> GetAllCategorys()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from Category");
            List<Category> Categorys = new List<Category>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Category Category = new Category();
                Category.ID= (int)(dataRow["ID"]);
                Category.Name = (string)(dataRow["Name"]);
                Categorys.Add(Category);
            }
            return Categorys;
        }
        // Select Category by ID 
        public static List<Category> GetCategoryByPattern(string pattern)
        {
            List<Category> Categorys = new List<Category>();

            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from Category Where Name like N'%{pattern}%'");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Category Category = new Category();
                Category.ID = (int)(dataRow["ID"]);
                Category.Name = (string)(dataRow["Name"]);
                Categorys.Add(Category);
            }
            return Categorys;
        }

        // Add Category
        public static bool AddCategory(Category Category)
        {
            string Command = $"Insert into Category (Name) Values  (N'{Category.Name}')";
            return DatabaseHelper.ExecutDML(Command);
        }

        //Update Category
        public static bool UpdateCategory(Category Category)
        {
            string Command = $"Update  Category set Name = (N'{Category.Name}') Where ID = {Category.ID}";
            return DatabaseHelper.ExecutDML(Command);
        }
        //Delete Category
        public static bool DeleteCategory(int ID)
        {
            string Command = $"Delete from Category Where ID =  {ID}";
            return DatabaseHelper.ExecutDML(Command);
        }
        //Delete All Category
        public static bool DeleteAllCategory()
        {
            string Command = $"Delete from Category";
            return DatabaseHelper.ExecutDML(Command);
        }

    }
}
