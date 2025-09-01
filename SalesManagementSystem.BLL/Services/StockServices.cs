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
    public class StockServices
    {
        public static List<Stock> GetAllStocks()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery("Select * from Stock");
            List<Stock> Stocks = new List<Stock>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Stock Stock = new Stock();
                Stock.ID = (int)(dataRow["ID"]);
                Stock.Location = (string)(dataRow["Location"]);
                Stocks.Add(Stock);
            }
            return Stocks;
        }
        // Select Stock by ID 
        public static Stock GetStockByID(int ID)
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from Stock Where ID ={ID}");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            Stock Stock = new Stock();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Stock.ID = (int)(dataRow["ID"]);
                Stock.Location = (string)(dataRow["Location"]);
            }
            return Stock;
        }

        // Add Stock
        public static bool AddStock(Stock Stock)
        {
            string Command = $"Insert into Stock Values () {Stock.ID} , {Stock.Location}";
            return DatabaseHelper.ExecutDML(Command);
        }

        //Update Stock
        public static bool UpdateStock(Stock Stock)
        {
            string Command = $"Insert into Stock Values () {Stock.ID} , {Stock.Location}";
            return DatabaseHelper.ExecutDML(Command);
        }
        //Delete Stock
        public static bool DeleteStock(int ID)
        {
            string Command = $"Delete from Stock Where ID =  {ID}";
            return DatabaseHelper.ExecutDML(Command);
        }

    }


}
