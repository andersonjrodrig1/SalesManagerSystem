using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Repositories.Connection
{
    public class ConnectionString
    {
        private static string salesConnection = "SalesConnection";

        public static string GetConnectionString() => System.Configuration.ConfigurationManager.ConnectionStrings[salesConnection].Name;
    }
}
