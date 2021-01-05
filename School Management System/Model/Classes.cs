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
    class Classes
    {
        SqlConnection conn;
        public Classes(SqlConnection conn)
        {
            this.conn = conn;
        }
        public Clas GetClass(int cId)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Classes WHERE cId = '{0}'", cId);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Clas clas = null;
            while (reader.Read())
            {
                clas = new Clas();
                clas.cId = reader.GetInt32(reader.GetOrdinal("cId"));
                clas.clas = reader.GetInt32(reader.GetOrdinal("class"));
                clas.classFee = reader.GetInt32(reader.GetOrdinal("classFee"));
            }
            conn.Close();
            return clas;
        }
        public bool AddClass(Clas c)
        {
            try
            {
                conn.Open();
                string query = String.Format("INSERT INTO Classes VALUES ('{0}','{1}')", c.clas, c.classFee);
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Failed to add Class");
                return false;
            }
        }
        public bool UpdateClass(Clas c, int cId)
        {
            try
            {
                conn.Open();
                string query = String.Format("UPDATE Classes SET class ='{0}', classFee = '{1}' WHERE cId = '{2}'", c.clas, c.classFee, cId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Update Class Failed, Class already exist");
                return false;
            }
        }
        public bool DeleteClass(int cId)
        {
            try
            {
                conn.Open();
                string query = String.Format("DELETE FROM Classes WHERE cId = '{0}'", cId);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Class Delete Failed, Invalid cId");
                return false;
            }
    
        }

        public ArrayList GetAllClasses()
        {
            ArrayList classes = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Classes";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int a = reader.GetInt32(reader.GetOrdinal("cId"));
                classes.Add(a);
            }
            conn.Close();
            return classes;
        }
    }
}
