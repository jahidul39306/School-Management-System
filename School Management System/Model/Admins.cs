using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    class Admins
    {
        SqlConnection conn;
        
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        
    }
}
