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
                conn.Close();
                MessageBox.Show("User Name is taken, choose another User Name");
                return false;
            }
        }
        public bool UpdateTeacher(Teacher teacher, int tId)
        {
            /*conn.Open();
            Console.WriteLine(teacher.name + " 569");
            string query = string.Format("UPDATE Teachers SET  name = '{0}', gender = '{1}', contact = '{2}', address = '{3}', userName = '{4}', password = '{5}' WHERE tId = '{6}'", teacher.name, teacher.gender, teacher.contact, teacher.address, teacher.userName, teacher.password, tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;*/
            try
            {
                conn.Open();
                string query = string.Format("UPDATE Teachers SET  name = '{0}', gender = '{1}', contact = '{2}', address = '{3}', userName = '{4}', password = '{5}' WHERE tId = {6}", teacher.name, teacher.gender, teacher.contact, teacher.address, teacher.userName, teacher.password, tId);
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

        public bool DeleteTeacher(int tId)
        {
            try
            {
                conn.Open();
                string query1 = string.Format("DELETE FROM Teachers_Courses WHERE tId = {0}", tId);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                int x = cmd1.ExecuteNonQuery();

                string query2 = string.Format("DELETE FROM Teachers_Sections WHERE tId = {0}", tId);
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                int y = cmd2.ExecuteNonQuery();

                string query3 = string.Format("DELETE FROM Teachers_Classes WHERE tId = {0}", tId);
                SqlCommand cmd3 = new SqlCommand(query3, conn);
                int z = cmd3.ExecuteNonQuery();

                string query = String.Format("DELETE FROM Teachers WHERE tId = '{0}'", tId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0 && x > 0 && y > 0 && z > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to delete Teacher. Invalid Teacher Id");
                return false;
            }

        }
        public ArrayList GetAllTeachers()
        {
            ArrayList teachers = new ArrayList();
            conn.Open();
            string query = "SELECT tId, name, gender, contact, address, userName FROM Teachers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher t = new Teacher();
                t.tId = reader.GetInt32(reader.GetOrdinal("tId"));
                t.name = reader.GetString(reader.GetOrdinal("name"));
                t.gender = reader.GetString(reader.GetOrdinal("gender"));
                t.contact = reader.GetString(reader.GetOrdinal("contact"));
                t.address = reader.GetString(reader.GetOrdinal("address"));
                t.userName = reader.GetString(reader.GetOrdinal("userName"));
                teachers.Add(t);
            }
            conn.Close();
            return teachers;
        }

        public ArrayList SearchTeachers(string search)
        {
            ArrayList teachers = new ArrayList();
            conn.Open();
           
            string query = string.Format("SELECT * FROM Teachers WHERE name LIKE '%{0}%' OR gender LIKE '%{0}%' OR contact LIKE '%{0}%' OR address LIKE '%{0}%' OR userName LIKE '%{0}%'", search);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher t = new Teacher();
                t.tId = reader.GetInt32(reader.GetOrdinal("tId"));
                t.name = reader.GetString(reader.GetOrdinal("name"));
                t.gender = reader.GetString(reader.GetOrdinal("gender"));
                t.contact = reader.GetString(reader.GetOrdinal("contact"));
                t.address = reader.GetString(reader.GetOrdinal("address"));
                t.userName = reader.GetString(reader.GetOrdinal("userName"));
                teachers.Add(t);
            }
            conn.Close();
            return teachers;
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
        public Teacher GetTeacher(int tId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Teachers WHERE tId = '{0}'", tId);
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
            string query = string.Format("SELECT secId FROM Teachers_Sections WHERE tId = '{0}'", tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int secId = reader.GetInt32(reader.GetOrdinal("secId"));
                sections.Add(secId);

            }
            conn.Close();
            return sections;
        }

        public ArrayList GetTeacherAllClasses(int tId)
        {
            conn.Open();
            ArrayList classes = new ArrayList();
            string query = string.Format("SELECT cId FROM Teachers_Classes where tId = '{0}'", tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int clsId = reader.GetInt32(reader.GetOrdinal("cId"));
                classes.Add(clsId);
             
            }
            conn.Close();
            return classes;
        }

        public ArrayList GetTeacherAllCourses(int tId)
        {
            conn.Open();
            ArrayList courses = new ArrayList();
            string query = string.Format("SELECT coId FROM Teachers_Courses where tId = '{0}'", tId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int courseId = reader.GetInt32(reader.GetOrdinal("coId"));
                courses.Add(courseId);

            }
            conn.Close();
            return courses;
        }

        public int AssignResult(int cId, int secId, int sId, int coId, int tMark, int obMark)
        {
            
            conn.Open();
            string query = string.Format("SELECT * FROM Students WHERE cId = {0} AND secId = {1} AND sId = {2}", cId, secId, sId);
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            if (r == 0) 
            {
                conn.Close();
                return 1;
            }

            string query2 = string.Format("SELECT * FROM Results WHERE coId = {0} AND sId = {1}", coId, sId);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            int x = Convert.ToInt32(cmd2.ExecuteScalar());
            if (x != 0)
            {
                conn.Close();
                return 2;
            }
            if (r > 0 && x == 0)
            {
                string query1 = string.Format("INSERT INTO Results (totalMark, obtainedMark, coId, sId) VALUES ({0}, {1}, {2}, {3})", tMark, obMark, coId, sId);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                int result = cmd1.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return 0;
                return 1;
            }
            conn.Close();
            return 1;
                
        }
        public Result GetCourseResult(int cId, int secId, int sId, int coId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Students WHERE cId = {0} AND secId = {1} AND sId = {2}", cId, secId, sId);
            SqlCommand cmd = new SqlCommand(query, conn);
            
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            //Result result = null;
            if (count > 0)
            {
                string query1 = string.Format("SELECT * FROM Results WHERE sId = {0} AND coId = {1}", sId, coId);
                
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                Result result = null;
                while (reader1.Read())
                {
                    Console.WriteLine(reader1.GetInt32(reader1.GetOrdinal("rId")));
                    result = new Result();
                    result.rId = reader1.GetInt32(reader1.GetOrdinal("rId"));
                    result.totalMark = reader1.GetInt32(reader1.GetOrdinal("totalMark"));
                    result.obtainedMark = reader1.GetInt32(reader1.GetOrdinal("obtainedMark"));
                    result.coId = reader1.GetInt32(reader1.GetOrdinal("coId"));
                    result.sId = reader1.GetInt32(reader1.GetOrdinal("sId"));
                }
                conn.Close();
                return result;
            }
            conn.Close();
            return null;
        }
        public bool UpdateResult(int cId, int secId, int sId, int coId, int tMark, int obMark)
        {

            conn.Open();
            string query = string.Format("SELECT * FROM Students WHERE cId = {0} AND secId = {1} AND sId = {2}", cId, secId, sId);
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            int r = Convert.ToInt32(cmd.ExecuteScalar());

            if (r > 0)
            {
                string query1 = string.Format("UPDATE Results SET totalMark = {0}, obtainedMark = {1} WHERE coId = {2} AND sId = {3}", tMark, obMark, coId, sId);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                int result = cmd1.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            conn.Close();
            return false;

        }
        public ArrayList GetAllTeachersId()
        {
            ArrayList teachers = new ArrayList();
            conn.Open();
            string query = string.Format("SELECT * FROM Teachers");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                int t = reader.GetInt32(reader.GetOrdinal("tId"));
                teachers.Add(t);
            }
            conn.Close();
            return teachers;
        }
        public int GetTotalTeachers()
        {

            conn.Open();
            string query = String.Format("Select count(*) from Teachers");
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return r;

        }
    }
}
