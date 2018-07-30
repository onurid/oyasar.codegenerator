using System.Data;
using System.Data.SqlClient;

namespace OYASAR.CodeGenerator.Lib.Core
{
    internal sealed class DataAccessLayer
    {
        private readonly SqlConnection sqlConnection;

        private readonly SqlCommand sqlCommand;

        private const string strConnection = "data source=hbsql01.ipnordic.dk;initial catalog=HotelBoss;persist security info=True;user id=service.HotelBoss;password=r75515ybade431d536k0490Dv95wEQ;MultipleActiveResultSets=True;";

        internal DataAccessLayer(string strConnection)
        {
            sqlConnection = new SqlConnection(strConnection);

            sqlCommand = new SqlCommand { Connection = sqlConnection };
        }

        internal DataAccessLayer()
        {
            sqlConnection = new SqlConnection(strConnection);

            sqlCommand = new SqlCommand { Connection = sqlConnection };

            sqlCommand.Connection = sqlConnection;
        }

        private void ConnectionOpen()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        private void ConnectionClose()
        {
            if (sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        internal DataRowCollection GetSchemaTable(string cmd)
        {
            ConnectionClose();

            ConnectionOpen();

            sqlCommand.CommandText = cmd;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SchemaOnly);

            var result = sqlDataReader.GetSchemaTable();

            ConnectionClose();

            return result.Rows;
        }

        internal DataRowCollection SqlExecute(string cmd)
        {
            var result = new DataTable();

            ConnectionClose();

            ConnectionOpen();

            sqlCommand.CommandText = cmd;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            result.Load(sqlDataReader);

            ConnectionClose();

            return result.Rows;
        }
    }
}
