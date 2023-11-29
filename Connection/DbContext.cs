using System;
using System.Data;
using System.Data.SqlClient;
namespace DbContextEdition.Connection
{
    public class DbContext
    {
        string connString = "Data Source=DOPT2210\\SQLEXPRESS;" +
            "Initial Catalog=QlXeMay;Integrated Security=True;";
            
        public DbContext() 
        {

        }
        public DataTable GetTable(string query)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(connString))
            using(var sqlAdapter = new SqlDataAdapter(query, connection))
            {
                connection.Open();
                sqlAdapter.Fill(dataTable);
            }
            return dataTable;
        }
        public void ExcuteQuery(string query)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
        
    }

}
