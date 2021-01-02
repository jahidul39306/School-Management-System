using System;
using System.Collections.Generic;
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
    }
}
