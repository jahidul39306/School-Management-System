using School_Management_System.Model;
using System;
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


    }
}
