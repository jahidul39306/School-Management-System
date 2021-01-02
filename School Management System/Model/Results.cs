using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    public class Results
    {
        SqlConnection conn;
        public Results(SqlConnection conn)
        {
            this.conn = conn;
        }
        
    }
}
