using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool AddTeacher(Teacher teacher)
        {
            try
            {
                conn.Open();
                string query = string.Format("Insert INTO Teachers VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", teacher.name, teacher.gender, teacher.contact, teacher.address, teacher.userName, teacher.password);
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("User Name is taken, choose another User Name");
                return false;
            }
        }
        public bool UpdateTeacher(Teacher teacher, int tId)
        {
            try
            {
                string query = string.Format("UPDATE Teachers SET  name = '{0}', gender = '{1}', contact = '{2}', address = '{3}', userName = '{4}', password = '{5}' WHERE tId = '{6}')", teacher.name, teacher.gender, teacher.contact, teacher.address, teacher.userName, teacher.password, teacher.tId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Update Failed. Chosoose another User Name.");
                return false;
            }

        }
    }
}

    

