using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL
{
    public static class DatabaseHelper
    {
     static SqlConnection SQLConnection = new SqlConnection();
        static DatabaseHelper()
        {
            SQLConnection.ConnectionString = "Server=MOSTAFA-ZAHRAN;Database=Store;Trusted_Connection=True; Encrypt = False; ";
        }

        public static  DataTable ExecuteQuery (string Query)
        {
            using (SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection))
            {

                using (SqlDataAdapter Adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();

                    Adapter.Fill(dataTable);

                    return dataTable;

                }
            }

        }

        public static bool ExecutDML(string DML)
        {
            using (SqlCommand SQLCommand = new SqlCommand(DML, SQLConnection))
            {
                SQLConnection.Open();

                int RowsAffected = SQLCommand.ExecuteNonQuery();


                SQLConnection.Close();

                return RowsAffected > 0;
            }
        }


    }
}
