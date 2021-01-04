using School_Management_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Controller
{
    public class CourseController
    {
        static Database db = new Database();
        public static int GetTotalCourse()
        {
            return db.Courses.GetTotalCourse();
        }
        public static bool AddCourse(Course c)
        {
            return db.Courses.AddCourse(c);
        }
        public static ArrayList GetAllCourses()
        {
            return db.Courses.GetAllCourses();
        }
        public static  ArrayList SearchCourses(string search)
        {
            return db.Courses.SearchCourses(search);
        }



    }
}
