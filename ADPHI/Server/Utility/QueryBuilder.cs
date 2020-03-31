using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ADPHI.Server.Utility
{
    public static class QueryBuilder<T>
    {
        public static IEnumerable<T> GetList(T entity)
        {
            IDbConnection connection = ConnectionManager.GetConnection();

            var result = connection.Query<T>(GetColumnList(entity));

            ConnectionManager.CloseConnection(connection);

            return result;
        }

        public static T SingleOrDefault(T entity)
        {
            IDbConnection connection = ConnectionManager.GetConnection();

            var result = connection.QueryFirstOrDefault<T>(GetColumnList(entity));

            ConnectionManager.CloseConnection(connection);

            return result;
        }

        public static int? ExecuteAction(string query)
        {
            IDbConnection connection = ConnectionManager.GetConnection();

            var result = connection.Execute(query);

            ConnectionManager.CloseConnection(connection);

            return result;
        }

        public static int? DeleteSQL(string query)
        {
            IDbConnection connection = ConnectionManager.GetConnection();

            var result = connection.Execute(query);

            ConnectionManager.CloseConnection(connection);

            return result;
        }


        private static string GetColumnList(T entity)
        {
            string selectedColumns = "Select ";
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (!prop.Name.Contains("_"))
                {
                    selectedColumns = selectedColumns + ConvertToPascalCase(prop.Name) + " AS " + prop.Name + ",";
                }
            }

            return selectedColumns + " From " + ConvertToPascalCase(entity.GetType().Name);
        }

        private static string ConvertToPascalCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
