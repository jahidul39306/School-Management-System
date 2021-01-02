using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    class Classes
    {
        SqlConnection conn;
        public Classes(SqlConnection conn)
        {
            this.conn = conn;
        }
        public Clas GetClass(int cId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Classes WHERE cId = '{0}'", cId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Clas clas = null;
            while (reader.Read())
            {
                clas = new Clas();
                clas.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                clas.clas = reader.GetInt32(reader.GetOrdinal("class"));
                clas.classFee = reader.GetInt32(reader.GetOrdinal("classFee"));
            }
            conn.Close();
            return clas;
        }
    }
}
