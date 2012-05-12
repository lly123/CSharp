using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class DbConnection
    {
        private void SimpleQuery()
        {
            var sqlConnection = new SqlConnection(GetConnectionString());
            var sqlCommand = new SqlCommand("select * from person", sqlConnection);

            using (sqlConnection)
            {
                sqlConnection.Open();
                var dataReader = sqlCommand.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        Console.Out.WriteLine("Person Name: " + dataReader["Name"]);
                    }                    
                }
            }
        }

        public void DoIt()
        {
            Console.Out.WriteLine("** " + GetAppName());

//            DbProviderFactory dbf = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
//            Console.Out.WriteLine(">> " + dbf);

            SimpleQuery();
        }

        private static string GetAppName()
        {
            return ConfigurationManager.AppSettings["AppName"];
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["ConnectionString"];
        }
    }
}
