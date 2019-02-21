using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL_Tutorial.SQL_Adapter
{
    class SqlAdapter
    {
        static string connectionString;

        public static string ConnectionString { get => connectionString; set => connectionString = value; }

        static DataSet Select(DataSet dataSet,string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = new SqlCommand(queryString, connection);

                return dataSet;
            }
        }

        static void Insert(DataSet dataSet, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = new SqlCommand(queryString, connection);
            }
        }

        static void Delete(DataSet dataSet, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.DeleteCommand = new SqlCommand(queryString, connection);
            }
        }

        static void Update(DataSet dataSet, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.UpdateCommand = new SqlCommand(queryString, connection);

            }
        }
    }
}
