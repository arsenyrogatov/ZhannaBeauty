using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhannaBeauty
{
    public class Worker
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Role { get; set; }
        public int Phone { get; set; }
        public decimal Wage { get; set; }
        public string pass { get; set; }

        public Worker() { }

        public Worker (int id, string fio, string role, int phone, decimal wage, string pwd)
        {
            Id = id;   
            FIO = fio;
            Role = role;
            Phone = phone;
            Wage = wage;
            pass = pwd;
        }

        public bool TryLogin(int phone, string password)
        {
            System.Data.SqlClient.SqlCommand WorkerLogin = new System.Data.SqlClient.SqlCommand("WorkerLogin", DBProvider.connection);
            WorkerLogin.CommandType = System.Data.CommandType.StoredProcedure;
            WorkerLogin.Parameters.Add("@login", System.Data.SqlDbType.Int);
            WorkerLogin.Parameters["@login"].Value = phone;
            WorkerLogin.Parameters.Add("@pass", System.Data.SqlDbType.VarChar, 50);
            WorkerLogin.Parameters["@pass"].Value = password;
            WorkerLogin.Parameters.Add("@workId", System.Data.SqlDbType.Int);
            WorkerLogin.Parameters["@workId"].Direction = System.Data.ParameterDirection.Output;
            DBProvider.Open();
            WorkerLogin.ExecuteNonQuery();
            DBProvider.Close();

            if (WorkerLogin.Parameters["@workId"].Value.ToString() != "-1")
            {
                Id = int.Parse(WorkerLogin.Parameters["@workId"].Value.ToString());
                GetInfo();
                return true;
            }
            else
                return false;
        }

        public void GetInfo()
        {
            System.Data.SqlClient.SqlCommand GetWorkerInfo = new System.Data.SqlClient.SqlCommand("GetWorkerInfo", DBProvider.connection);
            GetWorkerInfo.CommandType = System.Data.CommandType.StoredProcedure;
            GetWorkerInfo.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            GetWorkerInfo.Parameters["@Id"].Value = Id;

            GetWorkerInfo.Parameters.Add("@FIO", System.Data.SqlDbType.VarChar, 30);
            GetWorkerInfo.Parameters["@FIO"].Direction = System.Data.ParameterDirection.Output;

            GetWorkerInfo.Parameters.Add("@Role", System.Data.SqlDbType.VarChar, 20);
            GetWorkerInfo.Parameters["@Role"].Direction = System.Data.ParameterDirection.Output;

            GetWorkerInfo.Parameters.Add("@Phone", System.Data.SqlDbType.Int);
            GetWorkerInfo.Parameters["@Phone"].Direction = System.Data.ParameterDirection.Output;

            GetWorkerInfo.Parameters.Add("@Wage", System.Data.SqlDbType.Money);
            GetWorkerInfo.Parameters["@Wage"].Direction = System.Data.ParameterDirection.Output;

            GetWorkerInfo.Parameters.Add("@Pass", System.Data.SqlDbType.VarChar, 50);
            GetWorkerInfo.Parameters["@Pass"].Direction = System.Data.ParameterDirection.Output;

            DBProvider.Open();
            GetWorkerInfo.ExecuteNonQuery();
            DBProvider.Close();

            FIO = GetWorkerInfo.Parameters["@FIO"].Value.ToString();
            Role = GetWorkerInfo.Parameters["@Role"].Value.ToString();
            Wage = decimal.Parse(GetWorkerInfo.Parameters["@Wage"].Value.ToString());
            Phone = int.Parse(GetWorkerInfo.Parameters["@Phone"].Value.ToString());
            pass = GetWorkerInfo.Parameters["@Pass"].Value.ToString();
        }

        public void UpdateWorkerInfo()
        {
            System.Data.SqlClient.SqlCommand UpdateWorkerInfo = new System.Data.SqlClient.SqlCommand("UpdateWorkerInfo", DBProvider.connection);
            UpdateWorkerInfo.CommandType = System.Data.CommandType.StoredProcedure;
            UpdateWorkerInfo.Parameters.Add("@workerId", System.Data.SqlDbType.Int);
            UpdateWorkerInfo.Parameters["@workerId"].Value = Id;

            UpdateWorkerInfo.Parameters.Add("@workerFIO", System.Data.SqlDbType.VarChar, 30);
            UpdateWorkerInfo.Parameters["@workerFIO"].Value = FIO;

            UpdateWorkerInfo.Parameters.Add("@workerRole", System.Data.SqlDbType.VarChar, 20);
            UpdateWorkerInfo.Parameters["@workerRole"].Value = Role;

            UpdateWorkerInfo.Parameters.Add("@workerPhone", System.Data.SqlDbType.Int);
            UpdateWorkerInfo.Parameters["@workerPhone"].Value = Phone;

            UpdateWorkerInfo.Parameters.Add("@workerWage", System.Data.SqlDbType.Decimal);
            UpdateWorkerInfo.Parameters["@workerWage"].Value = Wage;

            UpdateWorkerInfo.Parameters.Add("@workerPwd", System.Data.SqlDbType.VarChar, 50);
            UpdateWorkerInfo.Parameters["@workerPwd"].Value = pass;

            DBProvider.Open();
            UpdateWorkerInfo.ExecuteNonQuery();
            DBProvider.Close();
        }

    }

    public static class WorkerTools
    {
        public static DataTable GetWorkers()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetWorkers = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetWorkers()", DBProvider.connection);
            GetWorkers.CommandType = System.Data.CommandType.Text;
            DBProvider.Open();
            recTable.Load(GetWorkers.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }

        public static bool AddWorker(string fio, string role, int phone, decimal wage, string pwd)
        {
            System.Data.SqlClient.SqlCommand AddWorker = new System.Data.SqlClient.SqlCommand("AddWorker", DBProvider.connection);
            AddWorker.CommandType = System.Data.CommandType.StoredProcedure;
            AddWorker.Parameters.Add("@fio", System.Data.SqlDbType.VarChar, 30);
            AddWorker.Parameters["@fio"].Value = fio;
            AddWorker.Parameters.Add("@role", System.Data.SqlDbType.VarChar, 20);
            AddWorker.Parameters["@role"].Value = role;
            AddWorker.Parameters.Add("@phone", System.Data.SqlDbType.Int);
            AddWorker.Parameters["@phone"].Value = phone;
            AddWorker.Parameters.Add("@wage", System.Data.SqlDbType.Money);
            AddWorker.Parameters["@wage"].Value = wage;
            AddWorker.Parameters.Add("@pwd", System.Data.SqlDbType.VarChar, 50);
            AddWorker.Parameters["@pwd"].Value = pwd;

            AddWorker.Parameters.Add("@response", System.Data.SqlDbType.Int);
            AddWorker.Parameters["@response"].Direction = ParameterDirection.Output;
            DBProvider.Open();
            AddWorker.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(AddWorker.Parameters["@response"].Value.ToString()) == 0;
        }
    }
}
