using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetAllresults()
        {
            conn.Open();

            string query = string.Format("SELECT sId,courseName, totalMark, obtainedMark FROM Results, Courses" +
                                            " WHERE Results.coId = Courses.coId");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            conn.Close();
            return dt;
        }
        public DataTable SearchResult(int search)
        {
            conn.Open();

            string query = string.Format("SELECT sId,courseName, totalMark, obtainedMark FROM Results, Courses" +
                                            " WHERE Results.coId = Courses.coId and sId='{0}'",search);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            conn.Close();
            return dt;

        }

    }
}
