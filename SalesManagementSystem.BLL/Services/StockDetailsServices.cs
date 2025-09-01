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
                StockDetails.SaleOedrId = (int)(dataRow["SaleOedrId"]);
                StockDetails.Quantity = (int)(dataRow["Quantity"]);
                StockDetailss.Add(StockDetails);
            }
            return StockDetailss;
        }
        // Select StockDetails by ID 
        public static StockDetails GetStockDetailsByID(int ID)
        {
            DataTable dataTable = DatabaseHelper.ExecuteQuery($"Select * from StockDetails Where ID ={ID}");
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            StockDetails StockDetails = new StockDetails();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                StockDetails StockDetails1 = new StockDetails();
                StockDetails1.Id = (int)(dataRow["StockDetailsID"]);
                StockDetails1.StockId = (int)(dataRow["StockId"]);
                StockDetails1.SaleOedrId = (int)(dataRow["SaleOedrId"]);
                StockDetails1.Quantity = (int)(dataRow["Quantity"]);

            }
            return StockDetails;
        }
    }
}
