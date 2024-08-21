using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Retail_Shop
{
    internal class DataBase
    {
        public DataSet DataAccess(string query, out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            sqlDataAdapter.Fill(dataSet);

                            error = string.Empty;
                            connection.Close();
                            return dataSet;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool ExecuteNonQuery(string query, out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        error = string.Empty;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public int ExecuteScalarQuery(string query, out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        error = string.Empty;
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
        }

    }
}
