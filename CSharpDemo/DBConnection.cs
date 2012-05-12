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
        private delegate void DbOperation(SqlConnection sqlConnection);

        private void SimpleQuery(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand("select * from person", sqlConnection);
            var dataReader = sqlCommand.ExecuteReader();

            using (dataReader)
            {
                while (dataReader.Read())
                {
                    Console.Out.WriteLine("Person Name: " + dataReader["Name"]);
                }                    
            }
        }

        private void DbDo(DbOperation opt)
        {
            using (var sqlConnection = new SqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();
                opt(sqlConnection);
            }
        }

        public void DoIt()
        {
            Console.Out.WriteLine("** " + GetAppName());

//            DbProviderFactory dbf = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
//            Console.Out.WriteLine(">> " + dbf);

            DbDo(SimpleQuery);

            DbDo((conn) =>
                     {
                         var transaction = conn.BeginTransaction();
                         try
                         {
                             var sqlCommand = new SqlCommand("update Person set name = @Name where id = 1", conn, transaction);
                             sqlCommand.Parameters.Add(new SqlParameter("@Name", "Lyli"));

                             sqlCommand.ExecuteNonQuery();
                             transaction.Commit();
                         }
                         catch (Exception)
                         {
                             transaction.Rollback();
                         }
                     });
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
