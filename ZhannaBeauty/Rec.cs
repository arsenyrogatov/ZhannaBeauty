using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace ZhannaBeauty
{
    public class Rec
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime recDate {  get; set; }
        public string Status { get; set; }

        public Rec (int recID, string recName, DateTime recDateTime, string recStatus)
        {
            this.ID = recID;
            this.Name = recName;
            this.recDate = recDateTime;
            this.Status = recStatus;
        }

        public void UpdateUserRec()
        {
            System.Data.SqlClient.SqlCommand UpdateUserRec = new System.Data.SqlClient.SqlCommand("UpdateUserRec", DBProvider.connection);
            UpdateUserRec.CommandType = System.Data.CommandType.StoredProcedure;
            UpdateUserRec.Parameters.Add("@servId", System.Data.SqlDbType.Int);
            UpdateUserRec.Parameters["@servId"].Value = ID;

            UpdateUserRec.Parameters.Add("@servName", System.Data.SqlDbType.VarChar, 40);
            UpdateUserRec.Parameters["@servName"].Value = Name;

            UpdateUserRec.Parameters.Add("@servDate", System.Data.SqlDbType.DateTime);
            UpdateUserRec.Parameters["@servDate"].Value = recDate;

            UpdateUserRec.Parameters.Add("@status", System.Data.SqlDbType.VarChar, 50);
            UpdateUserRec.Parameters["@status"].Value = Status;

            DBProvider.Open();
            UpdateUserRec.ExecuteNonQuery();
            DBProvider.Close();
        }

        public void DeleteRec()
        {
            System.Data.SqlClient.SqlCommand DeleteRec = new System.Data.SqlClient.SqlCommand("DeleteRec", DBProvider.connection);
            DeleteRec.CommandType = System.Data.CommandType.StoredProcedure;
            DeleteRec.Parameters.Add("@recId", System.Data.SqlDbType.Int);
            DeleteRec.Parameters["@recId"].Value = ID;

            DBProvider.Open();
            DeleteRec.ExecuteNonQuery();
            DBProvider.Close();
        }
    }

    public static class RecTools
    {
        public static void AddRec(int usrId, DateTime dateTime, string name)
        {
            System.Data.SqlClient.SqlCommand AddRec = new System.Data.SqlClient.SqlCommand("AddRec", DBProvider.connection);
            AddRec.CommandType = System.Data.CommandType.StoredProcedure;
            AddRec.Parameters.Add("@usrId", System.Data.SqlDbType.Int);
            AddRec.Parameters["@usrId"].Value = usrId;

            AddRec.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 40);
            AddRec.Parameters["@name"].Value = name;

            AddRec.Parameters.Add("@date", System.Data.SqlDbType.DateTime);
            AddRec.Parameters["@date"].Value = dateTime;

            DBProvider.Open();
            AddRec.ExecuteNonQuery();
            DBProvider.Close();
        }

        public static DataTable GetRecs()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetAllServices = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetRecs()", DBProvider.connection);
            GetAllServices.CommandType = System.Data.CommandType.Text;
            DBProvider.Open();
            recTable.Load(GetAllServices.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }
    }
}
