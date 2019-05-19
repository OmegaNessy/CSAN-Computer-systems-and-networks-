using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
    public class InventoryDAL
    {
        private SqlConnection connect = null;

        public void OpenConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
        }



        public void CloseConnection()
        {
            connect.Close();
        }

        public void InsertTerm(string dataTerm, string dataDefenition)
        {
            // Оператор SQL
            string sql = string.Format("Insert Into OSI" +
                   "(Term, Defenition) Values(@Term, @Defenition)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Term", dataTerm);
                cmd.Parameters.AddWithValue("@Defenition", dataDefenition);


                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTerm(string dataTerm)
        {
            string sql = string.Format("Delete from OSI where Term = '{0}'", dataTerm);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Ошибка!", ex);
                    throw error;
                }
            }
        }

        public void UpdateDefenition(string dataTerm, string dataDefenition)
        {
            string sql = string.Format("Update OSI Set Defenition = '{0}' Where Term = '{1}'",
                   dataDefenition, dataTerm);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllOSIAsDataTable()
        {
            DataTable inv = new DataTable();
            string sql = "Select * From OSI";
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                inv.Load(dr);
                dr.Close();
            }
            return inv;
        }
    }
}