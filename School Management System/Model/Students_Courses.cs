using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    class Students_Courses
    {
        SqlConnection conn;
        public Students_Courses(SqlConnection conn)
        {
            this.conn = conn;
        }
    }
}
