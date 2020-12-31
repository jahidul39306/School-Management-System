using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    class Database
    {
        public Admins Admins { get; set; }
        public Courses Courses { get; set; }
        public Sections Sections { get; set; }
        public Students Students { get; set; }
        public Students_Courses Students_Courses { get; set; }
        public Teachers Teachers { get; set; }
        

        public Database()
        {
            string connString = "Server = LAPTOP-V5SVLA1P; Integrated Security = true; Database = SchoolManagementDB";
            SqlConnection conn = new SqlConnection(connString);
            Admins = new Admins(conn);
            Courses = new Courses(conn);
            Sections = new Sections(conn);
            Students = new Students(conn);
            Students_Courses = new Students_Courses(conn);
            Teachers = new Teachers(conn);
            
        }
    }
}
