using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace ADPHI.Server.Utility
{
    public static class ConnectionManager
    {
        //private static string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.219.5)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL.jmssrv2)));User Id = AQFP01; Password = AQFP09; ";
        private static string connString = @"Server=192.168.219.10;port=3306;user id=jmsadmin;password=tsukitokaze;database=ADPHI;CharSet=utf8;";

        public static IDbConnection GetConnection()
        {

            var conn = new OracleConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public static void CloseConnection(IDbConnection conn)
        {
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
            {
                conn.Close();
            }
        }
    }
}
