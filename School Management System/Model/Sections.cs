using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            while (reader.Read())
            {
                section = new Section();
                section.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                section.secName = reader.GetString(reader.GetOrdinal("secName"));
                section.cId = reader.GetInt32(reader.GetOrdinal("cId"));
            }
            conn.Close();
            return section;
        }

        public bool AddSection(Section s)
        {
            try
            {
                conn.Open();
                string query = String.Format("INSERT INTO Sections VALUES ('{0}','{1}')", s.secName, s.cId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to add Section, Invalid cId");
                return false;
            }
        }
        public bool UpdateSection(Section s, int secId)
        {
            try
            {
                conn.Open();
                string query = String.Format("UPDATE Sections SET secName ='{0}', cId = '{1}' WHERE secId = '{2}'", s.secName, s.cId, secId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Update Section Failed, Class does not exist");
                return false;
            }
        }
        public bool DeleteSection(int secId)
        {
            try
            {
                conn.Open();
                string query1 = string.Format("DELETE FROM Teachers_Sections WHERE secID = {0}", secId);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                int x = cmd1.ExecuteNonQuery();

                string query = String.Format("DELETE FROM Sections WHERE secId = '{0}'", secId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0 ) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Section Delete Failed, Invalid secId");
                return false;
            }
        }
        public ArrayList GetAllSections()
        {
            ArrayList sections = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Sections";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int a = reader.GetInt32(reader.GetOrdinal("secId"));
                sections.Add(a);
            }
            conn.Close();
            return sections;
        }
        public ArrayList GetAllSecInfo()
        {
            ArrayList sections = new ArrayList();
            conn.Open();
            string query = "SELECT secId, secName, cId FROM Sections";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Section s = new Section();
                s.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                s.secName = reader.GetString(reader.GetOrdinal("secName"));
                s.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                sections.Add(s);
            }
            conn.Close();
            return sections;

        }
        public ArrayList SearchSectios(string search)
        {
            ArrayList sections = new ArrayList();
            conn.Open();



            string query = string.Format("SELECT * FROM Sections WHERE secName LIKE '%{0}%'", search);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Section section = new Section();
                section.secId = reader.GetInt32(reader.GetOrdinal("secId"));
                section.secName = reader.GetString(reader.GetOrdinal("secName"));
                section.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                sections.Add(section);



            }
            conn.Close();
            return sections;
        }
        public int GetTotalSection()
        {
            conn.Open();
            string query = String.Format("Select count(*) from Sections");
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return r;
        }
    }
}
