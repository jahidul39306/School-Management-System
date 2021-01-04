using System;
using System.Collections;
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
        public static bool UpdateTeacherPassword(string userName, string password)
        {
            return db.Teachers.UpdateTeacherPassword(userName, password);
        }
        public static ArrayList GetTeacherAllClasses(int tId)
        {
            return db.Teachers.GetTeacherAllClasses(tId);
        }
        public static ArrayList GetTeacherAllSections(int tId)
        {
            return db.Teachers.GetTeacherAllSections(tId);
        }
        public static ArrayList GetTeacherAllCourses(int tId)
        {
            return db.Teachers.GetTeacherAllCourses(tId);
        }
        public static int GetTotalTeacher()
        {
            return db.Teachers.GetTotalTeacher();
        }
    }
}
