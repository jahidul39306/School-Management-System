using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Model
{
    public class Teachers_Classes
    {
        SqlConnection conn;
        public Teachers_Classes(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddTeacher_Class(int tId, int cId)
        {
            try
            {
                conn.Open();
                string query = String.Format("INSERT INTO Teachers_Classes VALUES ('{0}','{1}')", tId, cId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to add Teacher to Class");
                return false;
            }
        }
        public bool UpdateTeacher_Class(Teacher_Class tc, int tcId)
        {
            try
            {
                conn.Open();
                string query = String.Format("UPDATE Teacher_Classes SET tId ='{0}', cId = '{1}' WHERE tcId = '{2}'", tc.tId, tc.cId, tcId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Update Teacher_Classes failed");
                return false;
            }
        }
        public bool DeleteTeacher_Classes(int tcId)
        {
            try
            {
                conn.Open();
                string query = String.Format("DELETE FROM Teachers_Classes WHERE tcId = '{0}'", tcId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Teacher Courses Delete Failed, Invalid tcId");
                return false;
            }
        }
    }
}
