using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    public class Sections
    {
        SqlConnection conn;
        public Sections(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Section GetSection(int secId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Sections WHERE secId = '{0}'", secId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Section section = null;
            while(reader.Read())
            {
                section = new Section();
                section.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                section.secName = reader.GetString(reader.GetOrdinal("secName"));
                section.cId = reader.GetInt32(reader.GetOrdinal("cId"));
            }
            conn.Close();
            return section;
        }
    }
}
