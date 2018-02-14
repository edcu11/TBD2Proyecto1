using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    public class DBConnection
    {
        private string connectionString { get; set; }
        private SqlConnection connection { get; set; }

        public DBConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }


        private QueryResult GetConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
            }                                                                          
            catch (Exception e)
            {
                return new QueryResult(e.Message);
            }

            return new QueryResult();
        }

        public bool IsConnectionValid()
        {
            GetConnection();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                return true;
            }
            return false;
        }


        public QueryResult ExecuteCommand(string sqlCommand, string[] columns)
        {
            GetConnection();

            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataReader myReader = command.ExecuteReader();
           
            QueryResult results = new QueryResult(new List<string>(columns));
            int count = 1;
            while (myReader.Read())
            {

                var newRow = new List<string>();
                newRow.Add(count.ToString());
                foreach (var field in results.Fields)
                {
                    string item = myReader[field].ToString();
                    newRow.Add(item);
                }

                results.Rows.Add(newRow);
                count++;
            }
            results.Fields = AddEmptyColumn(columns);
            connection.Close();
            return results;
        }

        private static List<string> AddEmptyColumn(string[] columns)
        {
            var columnasCompletas = new List<string>(columns);
            columnasCompletas.Insert(0, "Number");
            return columnasCompletas;
        }


        public SqlDataAdapter ExecuteCommandReader(string sqlCommand)
        {
            GetConnection();
            SqlDataAdapter myReader = new SqlDataAdapter(sqlCommand, connection);
            connection.Close();
            return myReader;
        }

    }
}
