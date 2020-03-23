namespace BillOrganizer.Classes
{
    public static class GlobalConfig
    {
        //I want my program to read the value of Connections, but have this class
        //assign its own data connections
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType dbType)
        {
            if (dbType == DatabaseType.Sql)
            {
                //For implementing a Sql database, create a Sql Connection class and make the
                //connection
                /* public class SqlConnector : IDataConnection
                 * {
                 *      public Bill CreateBill(Bill bill)
                 *      {
                 *          connect to a database with Dapper installed in VS
                 *      }
                 *  }
                 
                  SqlConnector sql = new SqlConnector();
                  Connections = sql;*/
            }
            else if (dbType == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
    }
}
