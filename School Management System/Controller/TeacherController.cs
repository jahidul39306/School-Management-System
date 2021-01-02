using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Model;

namespace School_Management_System.Controller
{
    public class TeacherController
    {
        static Database db = new Database();
        public static Teacher AuthenticateTeacher(string userName, string password)
        {
            return db.Teachers.AuthenticateTeacher(userName, password);
        }
    }
}
