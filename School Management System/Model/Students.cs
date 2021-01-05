using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Model
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddStudent(Student student)
        {
            try
            {
                conn.Open();
                string query = string.Format("INSERT INTO Students (name, roll, fatherName, motherName, dateOfBirth, dateOfAdmission, contact, address, gender, username, password, secId, cId)" +
                                               "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", student.name, student.roll, student.fatherName, student.motherName, student.dateOfBirth, student.dateOfAdmission, student.contact, student.address, student.gender, student.userName, student.password, student.secId, student.cId);

                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to add student. Try another User Name");
                return false;
            }
            
        }

        public bool UpdateStudent(Student student, int sId)
        {
            try
            {
                conn.Open();
                string query = string.Format("UPDATE Students SET name = '{0}', roll = '{1}', fatherName = '{2}', motherName = '{3}', dateOfBirth = '{4}', dateOfAdmission = '{5}', contact = '{6}', address = '{7}', gender = '{8}', username = '{9}', password = '{10}', secId = '{11}', cId = '{12}' WHERE sId = '{13}'", student.name, student.roll, student.fatherName, student.motherName, student.dateOfBirth, student.dateOfAdmission, student.contact, student.address, student.gender, student.userName, student.password, student.secId, student.cId, sId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Update Student failed, User Name is taken");
                return false;
            }        
        }
        public bool DeleteStudent(int sId)
        {
            try
            {
                conn.Open();
                string query = String.Format("DELETE FROM Students WHERE sId = '{0}'", sId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to delete student");
                return false;
            }
            
        }

        public Student AuthenticateStudent(string userName, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Students WHERE userName = '{0}' AND password = '{1}'", userName, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student student = null;
            while(reader.Read())
            {
                student = new Student();
                student.sId = reader.GetInt32(reader.GetOrdinal("sId"));
                student.name = reader.GetString(reader.GetOrdinal("name"));
                student.roll = reader.GetString(reader.GetOrdinal("roll"));
                student.fatherName = reader.GetString(reader.GetOrdinal("fatherName"));
                student.motherName = reader.GetString(reader.GetOrdinal("motherName"));
                student.dateOfBirth = reader.GetDateTime(reader.GetOrdinal("dateOfBirth"));
                student.dateOfAdmission = reader.GetDateTime(reader.GetOrdinal("dateOfAdmission"));
                student.contact = reader.GetString(reader.GetOrdinal("contact"));
                student.address = reader.GetString(reader.GetOrdinal("address"));
                student.gender = reader.GetString(reader.GetOrdinal("gender"));
                student.userName = reader.GetString(reader.GetOrdinal("userName"));
                student.password = reader.GetString(reader.GetOrdinal("password"));
                student.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                student.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                
            }
            conn.Close();
            return student;
        }

        public DataTable GetStudentResult(int sId)
        {
            conn.Open();
           
            string query = string.Format("SELECT courseName, totalMark, obtainedMark FROM Results, Courses" + 
                                            " WHERE Results.coId = Courses.coId AND Results.sId = '{0}' ", sId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
    
            adapter.Fill(dt);
            
            conn.Close();
            return dt;
            
        }
        public Student GetStudent(int sId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Students WHERE sId = '{0}'", sId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student student = null;
            while (reader.Read())
            {
                student = new Student();
                student.sId = reader.GetInt32(reader.GetOrdinal("sId"));
                student.name = reader.GetString(reader.GetOrdinal("name"));
                student.roll = reader.GetString(reader.GetOrdinal("roll"));
                student.fatherName = reader.GetString(reader.GetOrdinal("fatherName"));
                student.motherName = reader.GetString(reader.GetOrdinal("motherName"));
                student.dateOfBirth = reader.GetDateTime(reader.GetOrdinal("dateOfBirth"));
                student.dateOfAdmission = reader.GetDateTime(reader.GetOrdinal("dateOfAdmission"));
                student.contact = reader.GetString(reader.GetOrdinal("contact"));
                student.address = reader.GetString(reader.GetOrdinal("address"));
                student.gender = reader.GetString(reader.GetOrdinal("gender"));
                student.userName = reader.GetString(reader.GetOrdinal("userName"));
                student.password = reader.GetString(reader.GetOrdinal("password"));
                student.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                student.cId = reader.GetInt32(reader.GetOrdinal("cId"));

            }
            conn.Close();
            return student;
        }
        public ArrayList GetAllStudent()
        {
            ArrayList Students = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.sId = reader.GetInt32(reader.GetOrdinal("sId"));
                student.name = reader.GetString(reader.GetOrdinal("name"));
                student.roll = reader.GetString(reader.GetOrdinal("roll"));
                student.fatherName = reader.GetString(reader.GetOrdinal("fatherName"));
                student.motherName = reader.GetString(reader.GetOrdinal("motherName"));
                student.dateOfBirth = reader.GetDateTime(reader.GetOrdinal("dateOfBirth"));
                student.dateOfAdmission = reader.GetDateTime(reader.GetOrdinal("dateOfAdmission"));
                student.contact = reader.GetString(reader.GetOrdinal("contact"));
                student.address = reader.GetString(reader.GetOrdinal("address"));
                student.gender = reader.GetString(reader.GetOrdinal("gender"));
                student.userName = reader.GetString(reader.GetOrdinal("userName"));
                student.password = reader.GetString(reader.GetOrdinal("password"));
                student.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                student.cId = reader.GetInt32(reader.GetOrdinal("cId"));

                Students.Add(student);
            }
            conn.Close();
            return Students;
        }
        public ArrayList SearchStudent(string search)
        {
            ArrayList Students = new ArrayList();
            conn.Open();
            string query = string.Format("SELECT * FROM Students WHERE name LIKE '%{0}%' OR userName LIKE '%{0}%' OR fatherName LIKE '%{0}%' OR motherName LIKE '%{0}%'", search);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.sId = reader.GetInt32(reader.GetOrdinal("sId"));
                student.name = reader.GetString(reader.GetOrdinal("name"));
                student.roll = reader.GetString(reader.GetOrdinal("roll"));
                student.fatherName = reader.GetString(reader.GetOrdinal("fatherName"));
                student.motherName = reader.GetString(reader.GetOrdinal("motherName"));
                student.dateOfBirth = reader.GetDateTime(reader.GetOrdinal("dateOfBirth"));
                student.dateOfAdmission = reader.GetDateTime(reader.GetOrdinal("dateOfAdmission"));
                student.contact = reader.GetString(reader.GetOrdinal("contact"));
                student.address = reader.GetString(reader.GetOrdinal("address"));
                student.gender = reader.GetString(reader.GetOrdinal("gender"));
                student.userName = reader.GetString(reader.GetOrdinal("userName"));
                //student.password = reader.GetString(reader.GetOrdinal("password"));
                student.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                student.cId = reader.GetInt32(reader.GetOrdinal("cId"));

                Students.Add(student);
            }
            conn.Close();
            return Students;
        }

        public int GetTotalStudent()
        {
            
            conn.Open();
            string query = String.Format("Select count(*) from Students");
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return r;
            
        }
    }
}
