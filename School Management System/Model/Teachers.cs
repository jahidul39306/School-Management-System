using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    public class Teachers
    {
        SqlConnection conn;
        public Teachers(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Teacher AuthenticateTeacher(string userName, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Teachers WHERE userName = '{0}' AND password = '{1}'", userName, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Teacher teacher = null;
            while (reader.Read())
            {
                teacher = new Teacher();
                teacher.tId = reader.GetInt32(reader.GetOrdinal("tId"));
                teacher.name = reader.GetString(reader.GetOrdinal("name"));
                teacher.gender = reader.GetString(reader.GetOrdinal("gender"));
 
                teacher.contact = reader.GetString(reader.GetOrdinal("contact"));
                teacher.address = reader.GetString(reader.GetOrdinal("address"));
              
                teacher.userName = reader.GetString(reader.GetOrdinal("userName"));
                teacher.password = reader.GetString(reader.GetOrdinal("password"));
                

            }
            conn.Close();
            return teacher;
        }
    }
}
