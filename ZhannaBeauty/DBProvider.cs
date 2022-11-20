using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhannaBeauty
{
    public static class DBProvider
    {
        static string Server = "DESKTOP-OUCRF2M";
        static string Database = "салон красоты";
        public static System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection($"Data Source={Server};Initial Catalog=\"{Database}\";Integrated Security=True");
        public static void Open()
        {
            connection.Open();
        }

        public static void Close()
        {
            connection.Close();
        }
    }
}
