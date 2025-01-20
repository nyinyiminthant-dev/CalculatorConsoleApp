using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CalculatorConsoleApp.DataBase
{
    public static class MyConnection
    {

        public static SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "Calculator",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };
    }
}
