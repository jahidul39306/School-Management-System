using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    public class Admins
    {
        SqlConnection conn;
        
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Admin AuthenticateAdmin(string userName, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Admins WHERE userName = '{0}' AND password = '{1}'", userName, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.aId = reader.GetInt32(reader.GetOrdinal("aId"));
                admin.name = reader.GetString(reader.GetOrdinal("name"));
                admin.userName = reader.GetString(reader.GetOrdinal("userName"));
                admin.password = reader.GetString(reader.GetOrdinal("password"));


            }
            conn.Close();
            return admin;
        }
    }
}

    

