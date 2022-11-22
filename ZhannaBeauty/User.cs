using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhannaBeauty
{
    public class User
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birth { get; set; }
        public char Gen { get; set; }
        public int Phone { get; set; }
        public string pass { get; set; }

        public User () { }

        public User (int id, string fio, DateTime birth, char gen, int phone, string pwd) 
        {
            Id = id;
            FIO = fio;
            Birth = birth;
            Gen = gen;
            Phone = phone;
            pass = pwd;
        }

        public bool TryLogin (int phone, string password)
        {
            System.Data.SqlClient.SqlCommand UserLogin = new System.Data.SqlClient.SqlCommand("UserLogin", DBProvider.connection);
            UserLogin.CommandType = System.Data.CommandType.StoredProcedure;
            UserLogin.Parameters.Add("@login", System.Data.SqlDbType.Int);
            UserLogin.Parameters["@login"].Value = phone;
            UserLogin.Parameters.Add("@pass", System.Data.SqlDbType.VarChar, 50);
            UserLogin.Parameters["@pass"].Value = password;
            UserLogin.Parameters.Add("@usrId", System.Data.SqlDbType.Int);
            UserLogin.Parameters["@usrId"].Direction = System.Data.ParameterDirection.Output;
            DBProvider.Open();
            UserLogin.ExecuteNonQuery();
            DBProvider.Close();

            if (UserLogin.Parameters["@usrId"].Value.ToString() != "-1")
            {
                Id = int.Parse(UserLogin.Parameters["@usrId"].Value.ToString());
                GetInfo();
                return true;
            }
            else
                return false;
        }

        public void GetInfo ()
        {
            System.Data.SqlClient.SqlCommand GetUserInfo = new System.Data.SqlClient.SqlCommand("GetUserInfo", DBProvider.connection);
            GetUserInfo.CommandType = System.Data.CommandType.StoredProcedure;
            GetUserInfo.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            GetUserInfo.Parameters["@Id"].Value = Id;

            GetUserInfo.Parameters.Add("@FIO", System.Data.SqlDbType.VarChar, 30);
            GetUserInfo.Parameters["@FIO"].Direction = System.Data.ParameterDirection.Output;

            GetUserInfo.Parameters.Add("@Birth", System.Data.SqlDbType.Date);
            GetUserInfo.Parameters["@Birth"].Direction = System.Data.ParameterDirection.Output;

            GetUserInfo.Parameters.Add("@Gen", System.Data.SqlDbType.Char, 1);
            GetUserInfo.Parameters["@Gen"].Direction = System.Data.ParameterDirection.Output;

            GetUserInfo.Parameters.Add("@Phone", System.Data.SqlDbType.Int);
            GetUserInfo.Parameters["@Phone"].Direction = System.Data.ParameterDirection.Output;

            GetUserInfo.Parameters.Add("@Pass", System.Data.SqlDbType.VarChar, 50);
            GetUserInfo.Parameters["@Pass"].Direction = System.Data.ParameterDirection.Output;

            DBProvider.Open();
            GetUserInfo.ExecuteNonQuery();
            DBProvider.Close();

            FIO = GetUserInfo.Parameters["@FIO"].Value.ToString();
            Birth = DateTime.Parse(GetUserInfo.Parameters["@Birth"].Value.ToString());
            Gen = char.Parse(GetUserInfo.Parameters["@Gen"].Value.ToString());
            Phone = int.Parse(GetUserInfo.Parameters["@Phone"].Value.ToString());
            pass = GetUserInfo.Parameters["@Pass"].Value.ToString();
        }

        public void UpdateUserInfo()
        {
            System.Data.SqlClient.SqlCommand UpdateUserInfo = new System.Data.SqlClient.SqlCommand("UpdateUserInfo", DBProvider.connection);
            UpdateUserInfo.CommandType = System.Data.CommandType.StoredProcedure;
            UpdateUserInfo.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            UpdateUserInfo.Parameters["@Id"].Value = Id;

            UpdateUserInfo.Parameters.Add("@FIO", System.Data.SqlDbType.VarChar, 30);
            UpdateUserInfo.Parameters["@FIO"].Value = FIO;

            UpdateUserInfo.Parameters.Add("@Birth", System.Data.SqlDbType.Date);
            UpdateUserInfo.Parameters["@Birth"].Value = Birth;

            UpdateUserInfo.Parameters.Add("@Gen", System.Data.SqlDbType.Char, 1);
            UpdateUserInfo.Parameters["@Gen"].Value = Gen;

            UpdateUserInfo.Parameters.Add("@Phone", System.Data.SqlDbType.Int);
            UpdateUserInfo.Parameters["@Phone"].Value = Phone;

            UpdateUserInfo.Parameters.Add("@Pass", System.Data.SqlDbType.VarChar, 50);
            UpdateUserInfo.Parameters["@Pass"].Value = pass;

            DBProvider.Open();
            UpdateUserInfo.ExecuteNonQuery();
            DBProvider.Close();
        }

        public DataTable GetUserRecs ()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetUserRecs = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetUserRecs(@usrId)", DBProvider.connection);
            GetUserRecs.CommandType = System.Data.CommandType.Text;
            GetUserRecs.Parameters.Add("@usrId", System.Data.SqlDbType.Int);
            GetUserRecs.Parameters["@usrId"].Value = Id;
            DBProvider.Open();
            recTable.Load(GetUserRecs.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }

        public DataTable GetUserProc()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetUserProc = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetUserProc(@usrId)", DBProvider.connection);
            GetUserProc.CommandType = System.Data.CommandType.Text;
            GetUserProc.Parameters.Add("@usrId", System.Data.SqlDbType.Int);
            GetUserProc.Parameters["@usrId"].Value = Id;
            DBProvider.Open();
            recTable.Load(GetUserProc.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }
    }

    public static class UserTools
    {
        public static bool AddUser (string FIO, DateTime birth, char gen, int phone, string pwd)
        {
            System.Data.SqlClient.SqlCommand AddUser = new System.Data.SqlClient.SqlCommand("AddUser", DBProvider.connection);
            AddUser.CommandType = System.Data.CommandType.StoredProcedure;
            AddUser.Parameters.Add("@fio", System.Data.SqlDbType.VarChar, 30);
            AddUser.Parameters["@fio"].Value = FIO;
            AddUser.Parameters.Add("@birth", System.Data.SqlDbType.Date);
            AddUser.Parameters["@birth"].Value = birth;
            AddUser.Parameters.Add("@gen", System.Data.SqlDbType.Char);
            AddUser.Parameters["@gen"].Value = gen;
            AddUser.Parameters.Add("@phone", System.Data.SqlDbType.Int);
            AddUser.Parameters["@phone"].Value = phone;
            AddUser.Parameters.Add("@pwd", System.Data.SqlDbType.VarChar, 50);
            AddUser.Parameters["@pwd"].Value = pwd;

            AddUser.Parameters.Add("@response", System.Data.SqlDbType.Int);
            AddUser.Parameters["@response"].Direction = ParameterDirection.Output;
            DBProvider.Open();
            AddUser.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(AddUser.Parameters["@response"].Value.ToString()) == 0;
        }

        public static DataTable GetUsers ()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetUsers = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetUsers()", DBProvider.connection);
            GetUsers.CommandType = System.Data.CommandType.Text;
            DBProvider.Open();
            recTable.Load(GetUsers.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }
    }
}
