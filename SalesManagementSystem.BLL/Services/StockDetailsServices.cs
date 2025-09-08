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
    public class StockDetailsServices
    {
        //Select All StockDetails 
        public static List<StockDetails> GetAllStockDetailss()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from StockDetails");
            List<StockDetails> StockDetailss = new List<StockDetails>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                StockDetails StockDetails = new StockDetails();
                StockDetails.Id = (int)(dataRow["StockDetailsID"]);
                StockDetails.StockId = (int)(dataRow["StockId"]);
                StockDetails.SaleOedrId = (int)(dataRow["SaleOrderID"]);
                StockDetails.StockType = (type)Enum.Parse(typeof(type), dataRow["Type"].ToString());
                StockDetails.Money = (decimal)(dataRow["Money"]);
                StockDetails.DateTime = (DateTime)((dataRow["Time"]));
                StockDetailss.Add(StockDetails);
            }
            return StockDetailss;
        }
        public static bool AddStockDetails(StockDetails stockDetails)
        {
            string Command = $"INSERT INTO [StockDetails] ([StockID] , [SaleOrderID], [Money], [Type], [Time])VALUES ({stockDetails.StockId},{stockDetails.SaleOedrId},  {stockDetails.Money} ,'{stockDetails.StockType}' , '{stockDetails.DateTime:yyyy-MM-dd}');";
            return DatabaseHelper.ExecutDML(Command);
        }


    }
}
