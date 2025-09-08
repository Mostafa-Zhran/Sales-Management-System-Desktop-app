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
                Stock.Money = (decimal)(dataRow["Total Money"]);
                Stocks.Add(Stock);
            }
            return Stocks;
        }
        // Select Stock by ID 
        public static List<Stock>  GetStockID()
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select ID  from Stock ");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            List<Stock> Stocks = new List<Stock>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Stock Stock = new Stock();
                Stock.ID = (int)(dataRow["ID"]);
                Stocks.Add(Stock) ;
                
            }
            return Stocks;
        }

        // Add Stock
        public static bool AddStock(Stock Stock)
        {
            string Command = $"Insert into Stock ([Location], [Total Money])Values( N'{Stock.Location}' , {Stock.Money})";
            return DatabaseHelper.ExecutDML(Command);
        }

        //Update Stock
        public static bool UpdateStock(Stock Stock)
        {
            string Command = $"Update Stock Set [Total Money]  = [Total Money]  + {Stock.Money} Where ID = {Stock.ID}";
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
