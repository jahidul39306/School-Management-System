using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace School_Management_System.Model
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }

       /* public bool AddStudent(Student student)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Students (studentName, lvl, studentGender, userName, password)" +
                                           "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", student.studentName, student.lvl, student.studentGender, student.userName, student.password);

            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }*/

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
                student.fathrName = reader.GetString(reader.GetOrdinal("fatherName"));
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
       // public ArrayList GetAllStudents()
      
        /*public bool UpdateStudent(Student student)
        {
            
            return false;
        }*/
    }
}
