using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhannaBeauty
{
    public class Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Service (string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void UpdateService()
        {
            System.Data.SqlClient.SqlCommand UpdateService = new System.Data.SqlClient.SqlCommand("UpdateService", DBProvider.connection);
            UpdateService.CommandType = System.Data.CommandType.StoredProcedure;

            UpdateService.Parameters.Add("@servName", System.Data.SqlDbType.VarChar, 40);
            UpdateService.Parameters["@servName"].Value = Name;

            UpdateService.Parameters.Add("@servPrice", System.Data.SqlDbType.Money);
            UpdateService.Parameters["@servPrice"].Value = Price;

            DBProvider.Open();
            UpdateService.ExecuteNonQuery();
            DBProvider.Close();
        }

        public int DeleteService()
        {
            System.Data.SqlClient.SqlCommand DeleteService = new System.Data.SqlClient.SqlCommand("DeleteService", DBProvider.connection);
            DeleteService.CommandType = System.Data.CommandType.StoredProcedure;

            DeleteService.Parameters.Add("@servName", System.Data.SqlDbType.VarChar, 40);
            DeleteService.Parameters["@servName"].Value = Name;

            DeleteService.Parameters.Add("@response", System.Data.SqlDbType.Int);
            DeleteService.Parameters["@response"].Direction = ParameterDirection.Output;

            DBProvider.Open();
            DeleteService.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(DeleteService.Parameters["@response"].Value.ToString());
        }

    }

    public static class ServiceTools
    {
        public static DataTable GetServices()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetAllServices = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetAllServices()", DBProvider.connection);
            GetAllServices.CommandType = System.Data.CommandType.Text;
            DBProvider.Open();
            recTable.Load(GetAllServices.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }

        public static int AddService (string name, decimal price)
        {
            System.Data.SqlClient.SqlCommand AddService = new System.Data.SqlClient.SqlCommand("AddService", DBProvider.connection);
            AddService.CommandType = System.Data.CommandType.StoredProcedure;

            AddService.Parameters.Add("@servName", System.Data.SqlDbType.VarChar, 40);
            AddService.Parameters["@servName"].Value = name;

            AddService.Parameters.Add("@servPrice", System.Data.SqlDbType.Money);
            AddService.Parameters["@servPrice"].Value = price;

            AddService.Parameters.Add("@response", System.Data.SqlDbType.Int);
            AddService.Parameters["@response"].Direction = ParameterDirection.Output;

            DBProvider.Open();
            AddService.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(AddService.Parameters["@response"].Value.ToString());
        }
    }
}
