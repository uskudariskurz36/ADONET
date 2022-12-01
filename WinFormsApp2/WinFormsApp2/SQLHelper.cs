using System.Data.SqlClient;

namespace WinFormsApp2
{
    public class SQLHelper
    {
        public SqlConnection connection = new SqlConnection();
        public SqlCommand command = new SqlCommand();

        public SQLHelper()
        {
            connection.ConnectionString = "Server=.;Database=Z36TodoAppDB;Trusted_Connection=true";
            command.Connection = connection;
        }

        public void SetCommand(string query, List<MyParameter> parameters)
        {
            SetCommand(query, parameters.ToArray());
        }

        public void SetCommand(string query, params MyParameter[] parameters)
        {
            command.CommandText = query;

            foreach (MyParameter item in parameters)
            {
                command.Parameters.AddWithValue(item.ParameterName, item.ParameterValue);
            }
        }

        public int RunCommand()
        {
            int result = 0;

            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed && connection.State != System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                }
            }

            return result;
        }
    }
}
