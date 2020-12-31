using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    class Teachers
    {
        SqlConnection conn;
        public Teachers(SqlConnection conn)
        {
            this.conn = conn;
        }
    }
}
