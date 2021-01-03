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
    public class Teachers
    {
        SqlConnection conn;
        public Teachers(SqlConnection conn)
        {
            this.conn = conn;
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

        public bool UpdateTeacherPassword(string userName, string password)
        {
            conn.Open();
            string query = String.Format("UPDATE Teachers SET password = '{0}' WHERE userName = '{1}'", password, userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public ArrayList GetTeacherAllSections(int tId)
        {
            conn.Open();
            ArrayList sections = new ArrayList();
            string query = string.Format("SELECT secName FROM Sections, Teachers_Sections where Teachers_Sections.secId = Sections.secId AND Teachers_Sections.tId = '{0}'", tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string secName = reader.GetString(reader.GetOrdinal("secName"));
                sections.Add(secName);

            }
            conn.Close();
            return sections;
        }

        public ArrayList GetTeacherAllClasses(int tId)
        {
            conn.Open();
            ArrayList classes = new ArrayList();
            string query = string.Format("SELECT class FROM Classes, Teachers_Classes where Teachers_Classes.cId = Classes.cId AND Teachers_Classes.tId = '{0}'", tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int clsName = reader.GetInt32(0);
                classes.Add(clsName);
             
            }
            conn.Close();
            return classes;
        }

        public ArrayList GetTeacherAllCourses(int tId)
        {
            conn.Open();
            ArrayList courses = new ArrayList();
            string query = string.Format("SELECT courseName FROM Courses, Teachers_Courses where Teachers_Courses.coId = Courses.coId AND Teachers_Courses.tId = '{0}'", tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string courseName = reader.GetString(reader.GetOrdinal("courseName"));
                courses.Add(courseName);

            }
            conn.Close();
            return courses;
        }
    }
}
