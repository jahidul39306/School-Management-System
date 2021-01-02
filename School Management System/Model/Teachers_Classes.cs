using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    public class Teachers_Classes
    {
        SqlConnection conn;
        public Teachers_Classes(SqlConnection conn)
        {
            this.conn = conn;
        }
    }
}
