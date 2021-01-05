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
        public Classes Classes { get; set; }
        public Courses Courses { get; set; }
        public Results Results { get; set; }

        public Sections Sections { get; set; }
        public Students Students { get; set; }
        public Teachers Teachers { get; set; }
        public Teachers_Classes Teachers_Classes { get; set; }
        public Teachers_Courses Teachers_Courses { get; set; }
        public Teachers_Sections Teachers_Sections { get; set; }


        public Database()
        {
            string connString = "Server =DISHAN\\SQLEXPRESS; Database = SchoolManagementSystemDB;User Id=sa;Password=Nayamet@19392;";
            SqlConnection conn = new SqlConnection(connString);
            Admins = new Admins(conn);
            Classes = new Classes(conn);
            Courses = new Courses(conn);
            Sections = new Sections(conn);
            Students = new Students(conn);
            Results = new Results(conn);
            Teachers = new Teachers(conn);
            Teachers_Classes = new Teachers_Classes(conn);
            Teachers_Courses = new Teachers_Courses(conn);
            Teachers_Sections = new Teachers_Sections(conn);
        }
    }
}
