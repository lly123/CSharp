using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class DbConnection
    {
        public void DoIt()
        {
            DbProviderFactory dbf = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
            Console.Out.WriteLine(">> " + dbf);
        }
    }
}
