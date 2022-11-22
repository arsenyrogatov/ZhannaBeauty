using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhannaBeauty
{
    public class Material
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string MesUnits { get; set; }

        public Material (string name, int count, string mesunit)
        {
            Name = name;   
            Count = count;
            MesUnits = mesunit;
        }

        public void UpdateMaterial()
        {
            System.Data.SqlClient.SqlCommand UpdateMaterial = new System.Data.SqlClient.SqlCommand("UpdateMaterial", DBProvider.connection);
            UpdateMaterial.CommandType = System.Data.CommandType.StoredProcedure;
            UpdateMaterial.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 40);
            UpdateMaterial.Parameters["@name"].Value = Name;

            UpdateMaterial.Parameters.Add("@count", System.Data.SqlDbType.Int);
            UpdateMaterial.Parameters["@count"].Value = Count;

            UpdateMaterial.Parameters.Add("@mesunit", System.Data.SqlDbType.VarChar, 2);
            UpdateMaterial.Parameters["@mesunit"].Value = MesUnits;

            DBProvider.Open();
            UpdateMaterial.ExecuteNonQuery();
            DBProvider.Close();
        }

        public int DeleteMaterial()
        {
            System.Data.SqlClient.SqlCommand DeleteMaterial = new System.Data.SqlClient.SqlCommand("DeleteMaterial", DBProvider.connection);
            DeleteMaterial.CommandType = System.Data.CommandType.StoredProcedure;

            DeleteMaterial.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 40);
            DeleteMaterial.Parameters["@name"].Value = Name;

            DeleteMaterial.Parameters.Add("@response", System.Data.SqlDbType.Int);
            DeleteMaterial.Parameters["@response"].Direction = ParameterDirection.Output;

            DBProvider.Open();
            DeleteMaterial.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(DeleteMaterial.Parameters["@response"].Value.ToString());
        }
    }

    public static class MaterialTools
    {
        public static DataTable GetMaterials()
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetMaterials = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetMaterials()", DBProvider.connection);
            GetMaterials.CommandType = System.Data.CommandType.Text;
            DBProvider.Open();
            recTable.Load(GetMaterials.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }

        public static int AddMaterial(string name, int count, string mesunit)
        {
            System.Data.SqlClient.SqlCommand AddMaterial = new System.Data.SqlClient.SqlCommand("AddMaterial", DBProvider.connection);
            AddMaterial.CommandType = System.Data.CommandType.StoredProcedure;

            AddMaterial.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 40);
            AddMaterial.Parameters["@name"].Value = name;

            AddMaterial.Parameters.Add("@count", System.Data.SqlDbType.Int);
            AddMaterial.Parameters["@count"].Value = count;

            AddMaterial.Parameters.Add("@mesUnit", System.Data.SqlDbType.VarChar, 2);
            AddMaterial.Parameters["@mesUnit"].Value = mesunit;

            AddMaterial.Parameters.Add("@response", System.Data.SqlDbType.Int);
            AddMaterial.Parameters["@response"].Direction = ParameterDirection.Output;

            DBProvider.Open();
            AddMaterial.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(AddMaterial.Parameters["@response"].Value.ToString());
        }

        public static int AddProcMaterial(int procId, string name, int count)
        {
            System.Data.SqlClient.SqlCommand AddProcMaterial = new System.Data.SqlClient.SqlCommand("AddProcMaterial", DBProvider.connection);
            AddProcMaterial.CommandType = System.Data.CommandType.StoredProcedure;

            AddProcMaterial.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 40);
            AddProcMaterial.Parameters["@name"].Value = name;

            AddProcMaterial.Parameters.Add("@count", System.Data.SqlDbType.Int);
            AddProcMaterial.Parameters["@count"].Value = count;

            AddProcMaterial.Parameters.Add("@procId", System.Data.SqlDbType.Int);
            AddProcMaterial.Parameters["@procId"].Value = procId;

            AddProcMaterial.Parameters.Add("@response", System.Data.SqlDbType.Int);
            AddProcMaterial.Parameters["@response"].Direction = ParameterDirection.Output;

            DBProvider.Open();
            AddProcMaterial.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(AddProcMaterial.Parameters["@response"].Value.ToString());
        }

        public static DataTable GetMaterialsByProcedure (int procId)
        {
            var recTable = new DataTable();
            System.Data.SqlClient.SqlCommand GetMaterialsByProcedure = new System.Data.SqlClient.SqlCommand("SELECT * FROM GetMaterialsByProcedure(@procId)", DBProvider.connection);
            GetMaterialsByProcedure.CommandType = System.Data.CommandType.Text;
            GetMaterialsByProcedure.Parameters.Add("@procId", System.Data.SqlDbType.Int);
            GetMaterialsByProcedure.Parameters["@procId"].Value = procId;
            DBProvider.Open();
            recTable.Load(GetMaterialsByProcedure.ExecuteReader());
            DBProvider.Close();
            return recTable;
        }

        public static int UpdateProcMaterial (int procId, string matName, int count)
        {
            System.Data.SqlClient.SqlCommand UpdateProcMaterial = new System.Data.SqlClient.SqlCommand("UpdateProcMaterial", DBProvider.connection);
            UpdateProcMaterial.CommandType = System.Data.CommandType.StoredProcedure;

            UpdateProcMaterial.Parameters.Add("@procId", System.Data.SqlDbType.Int);
            UpdateProcMaterial.Parameters["@procId"].Value = procId;

            UpdateProcMaterial.Parameters.Add("@matName", System.Data.SqlDbType.VarChar, 40);
            UpdateProcMaterial.Parameters["@matName"].Value = matName;

            UpdateProcMaterial.Parameters.Add("@count", System.Data.SqlDbType.Int);
            UpdateProcMaterial.Parameters["@count"].Value = count;

            UpdateProcMaterial.Parameters.Add("@response", System.Data.SqlDbType.Int);
            UpdateProcMaterial.Parameters["@response"].Direction = ParameterDirection.Output;

            DBProvider.Open();
            UpdateProcMaterial.ExecuteNonQuery();
            DBProvider.Close();

            return int.Parse(UpdateProcMaterial.Parameters["@response"].Value.ToString());
        }

        public static void DeleteProcMaterial (int procId, string matName)
        {
            System.Data.SqlClient.SqlCommand DeleteProcMaterial = new System.Data.SqlClient.SqlCommand("DeleteProcMaterial", DBProvider.connection);
            DeleteProcMaterial.CommandType = System.Data.CommandType.StoredProcedure;

            DeleteProcMaterial.Parameters.Add("@procId", System.Data.SqlDbType.Int);
            DeleteProcMaterial.Parameters["@procId"].Value = procId;

            DeleteProcMaterial.Parameters.Add("@matName", System.Data.SqlDbType.VarChar, 40);
            DeleteProcMaterial.Parameters["@matName"].Value = matName;

            DBProvider.Open();
            DeleteProcMaterial.ExecuteNonQuery();
            DBProvider.Close();
        }
    }
}
