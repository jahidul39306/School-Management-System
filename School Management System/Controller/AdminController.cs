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

        public static bool AddSection(Section s)
        {
            return db.Sections.AddSection(s);
        }
        public static bool UpdateSection(Section s, int secId)
        {
            return db.Sections.UpdateSection(s, secId);
        }

        public static bool DeleteSection(int secId)
        {
            return db.Sections.DeleteSection(secId);
        }

        public static bool AddCourse(Course c)
        {
            return db.Courses.AddCourse(c);
        }
        public static bool UpdateCourse(Course c, int coId)
        {
            return db.Courses.UpdateCourse(c, coId);
        }
        public static bool DeleteCourse(int coId)
        {
            return db.Courses.DeleteCourse(coId);
        }

        public static ArrayList GetAllClasses()
        {
            return db.Classes.GetAllClasses();
        }

        public static ArrayList GetAllCourses()
        {
            return db.Courses.GetAllCourses();
        }
        public static ArrayList GetAllSections()
        {
            return db.Sections.GetAllSections();
        }
        public static Section GetSection(int secId)
        {
            return db.Sections.GetSection(secId);
        }
        public static ArrayList GetAllSecInfo()
        {
            return db.Sections.GetAllSecInfo();
        }
        public static ArrayList SearchSectios(string search)
        {
            return db.Sections.SearchSectios(search);
        }
        public static ArrayList GetAllCoursesInfo()
        {
            return db.Courses.GetAllCoursesInfo();
        }
        public static ArrayList SearchCourses(string search)
        {
            return db.Courses.SearchCourses(search);
        }
        public static Course GetCourse(int coId)
        {
            return db.Courses.GetCourse(coId);
        }
        public static ArrayList GetAllTeachersId()
        {
            return db.Teachers.GetAllTeachersId();
        }
        public static bool AssignTeacher(int tId, int coId, int cId, int secId)
        {
            return db.Admins.AssignTeacher(tId, coId, cId, secId);
        }
        public static int GetTotalStudent()
        {
            return db.Students.GetTotalStudent();
        }
        public static int GetTotalTeachers()
        {
            return db.Teachers.GetTotalTeachers();
        }
        public static int GetTotalSection()
        {
            return db.Sections.GetTotalSection();
        }
        public static int GetTotalCourse()
        {
            return db.Courses.GetTotalCourse();
        }
        public static DataTable GetAllresults()
        {
            return db.Results.GetAllresults();
        }
        public static DataTable SearchResult(int search)
        {
            return db.Results.SearchResult(search);
        }
        public static ArrayList GetAllStudent()
        {
            return db.Students.GetAllStudent();
        }
        public static ArrayList SearchStudent(string search)
        {
            return db.Students.SearchStudent(search);
        }
        public static int TotalEarning()
        {
            return db.Admins.TotalEarning();
        }
    }
}
