using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class BaseDAL 
    {
        public StockDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connectionString);
        }

        public string GetConnectionString()
        {
            /*string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("dbsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionString:FStoreDBAssignment"];*/
            string connectionString = "Server=(local);uid=sa;pwd=sa;database=FStoreDBAssignment;TrustServerCertificate=True";
            return connectionString;
        }
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
