using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Model;

namespace School_Management_System.Controller
{
    public class StudentController
    {
        static Database db = new Database();
        public static Student AuthenticateStudent(string userName, string password)
        {
            return db.Students.AuthenticateStudent(userName, password);
        }

        public static DataTable GetStudentResult(int sId)
        {
            return db.Students.GetStudentResult(sId);
        }
        public static bool AddStudent(Student student)
        {
            return db.Students.AddStudent(student);
        }
        public static Student GetStudent(int sId)
        {
            return db.Students.GetStudent(sId);
        }
        public static bool UpdateStudent(Student student, int sId)
        {
            return db.Students.UpdateStudent(student, sId);
        }
        public static bool DeleteStudent(int sId)
        {
            return db.Students.DeleteStudent(sId);
        }
    }
}
