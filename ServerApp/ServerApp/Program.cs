
using System;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer {

    class AccessConnectPureCode

    {
        static string connectionString = @"Data Source = Microsoft.ACE.OLEDB.12.0; Initial Catalog = D:\Учеба\4 семестр\Курсовая C#\Database.accdb";

        static SqlConnection myOleDbConnection = new SqlConnection(connectionString);

        public static void Main()
        {
            string dataTerm = "dsa";
            string dataDefenition = "asd";

            InventoryDAL DAL = new InventoryDAL();
            DAL.OpenConnection(connectionString);

            DAL.InsertTerm(dataTerm,dataDefenition);

            DAL.GetAllOSIAsDataTable();

            DAL.CloseConnection();
            Console.Read();
        }

    }
}