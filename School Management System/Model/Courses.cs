using System;
using System.Collections;
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
        public bool UpdateCourse(Course c, int coId)
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
                string query1 = string.Format("DELETE FROM Results WHERE coId = {0}", coId);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                int x = cmd1.ExecuteNonQuery();

                string query2 = string.Format("DELETE FROM Teachers_Courses WHERE coId = {0}", coId);
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                int y = cmd2.ExecuteNonQuery();

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
                conn.Close();                
                return false;
            }

        }
        public ArrayList GetAllCourses()
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int a = reader.GetInt32(reader.GetOrdinal("coId"));
                courses.Add(a);
            }
            conn.Close();
            return courses;
        }

        public ArrayList GetAllCoursesInfo()
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            string query = "SELECT coId, courseName, cId FROM Courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course c = new Course();
                c.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                c.courseName = reader.GetString(reader.GetOrdinal("courseName"));
                c.coId = reader.GetInt32(reader.GetOrdinal("coId"));
                courses.Add(c);
            }
            conn.Close();
            return courses;
        }
        public ArrayList SearchCourses(string search)
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            Console.WriteLine(search + " 5655");
            string query = String.Format("SELECT * FROM Courses WHERE courseName LIKE '%{0}%'", search);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course c = new Course();
                c.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                c.coId = reader.GetInt32(reader.GetOrdinal("coId"));
                c.courseName = reader.GetString(reader.GetOrdinal("courseName"));
                courses.Add(c);
            }
            conn.Close();
            return courses;
        }


        public Course GetCourse(int coId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Courses WHERE coId = '{0}'", coId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Course c = null;
            while (reader.Read())
            {
                c = new Course();
                c.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                c.courseName = reader.GetString(reader.GetOrdinal("courseName"));
                c.coId = reader.GetInt32(reader.GetOrdinal("coId"));
            }
            conn.Close();
            return c;
        }
        public int GetTotalCourse()
        {
            conn.Open();
            string query = String.Format("Select count(*) from Courses");
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return r;
        }




    }
}
