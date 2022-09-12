using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class DbHelper
    {
        private SqlConnection sqlConnection;

        public DbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public int ExecuteCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = createCommand(commandText, parameters);
            sqlCommand.Connection.Open();
            var rows = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();

            return rows;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            addParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

        }
    }
}
