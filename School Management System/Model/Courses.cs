using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Model
{
    public class Courses
    {
        SqlConnection conn;
        public Courses(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddCourse(Course c)
        {
            try
            {
                conn.Open();
                string query = String.Format("INSERT INTO Courses VALUES ('{0}','{1}')", c.courseName, c.cId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to add Course, Invalid cId");
                return false;
            }
        }
        public bool UpdateClass(Course c, int coId)
        {
            try
            {
                conn.Open();
                string query = String.Format("UPDATE Courses SET courseName ='{0}', cId = '{1}' WHERE coId = '{2}'", c.courseName, c.cId, coId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Update Course Failed, Class does not exist");
                return false;
            }
        }
        public bool DeleteCourse(int coId)
        {
            try
            {
                conn.Open();
                string query = String.Format("DELETE FROM Courses WHERE coId = '{0}'", coId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Course Delete Failed, Invalid coId");
                return false;
            }

        }

    }
}
