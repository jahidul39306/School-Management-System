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

        public bool AssignTeacher(int tId, int coId, int cId, int secId)
        {
            conn.Open();
            Console.WriteLine(tId);
            Console.WriteLine(coId);
            Console.WriteLine(cId);
            Console.WriteLine(secId);
            string query = string.Format("insert into Teachers_Courses values ({0}, {1})", tId, coId);
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            int x = cmd.ExecuteNonQuery();
            //conn.Close();
            //conn.Open();
            
            string query1 = string.Format("INSERT INTO Teachers_Classes VALUES ({0}, {1})", tId, cId);
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            //SqlDataReader reader1 = cmd1.ExecuteReader();
            int y = cmd1.ExecuteNonQuery();
            //conn.Close();

            //conn.Open();
            string query2 = string.Format("INSERT INTO Teachers_Sections VALUES ({0}, {1})", tId, secId);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            //SqlDataReader reader2 = cmd2.ExecuteReader();
            int z = cmd2.ExecuteNonQuery();
            conn.Close();
            if(x > 0 && y > 0 && z > 0)return true;
            else return false;


        }
        
        public int TotalEarning()
        {
            conn.Open();
            
            string query = String.Format("Select count(*) from Students");
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return r * 1000;

        }

    }
}

    

