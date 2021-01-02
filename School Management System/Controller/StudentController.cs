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
    }
}
