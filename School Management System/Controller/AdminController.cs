using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Model;

namespace School_Management_System.Controller
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string userName, string password)
        {
            return db.Admins.AuthenticateAdmin(userName, password);
        }
        public static bool AddTeacher(Teacher teacher)
        {
            return db.Teachers.AddTeacher(teacher);
        }
        public static Teacher GetTeacher(int tId)
        {
            return db.Teachers.GetTeacher(tId);
        }

        public static bool UpdateTeacher(Teacher teacher, int tId)
        {
            return db.Teachers.UpdateTeacher(teacher, tId);
        }
        public static bool DeleteTeacher(int tId)
        {
            return db.Teachers.DeleteTeacher(tId);
        }
        public static ArrayList GetAllTeachers()
        {
            return db.Teachers.GetAllTeachers();
        }
        public static ArrayList SearchTeachers(string search)
        {
            return db.Teachers.SearchTeachers(search);
        }
    }
}
