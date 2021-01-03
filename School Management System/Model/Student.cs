using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Model
{
    public class Student
    {
        public int sId { get; set; }
        public string name { get; set; }
        public string roll { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateOfAdmission { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string gender { get; set; }

        public string userName { get; set; }
        public string password { get; set; }
        public int secId { get; set; }
        public int cId { get; set; }

        //public Student(int sId, string name, string roll, string fatherName, string motherName, DateTime dob, DateTime doa, string con, string add, string gender, string uN, string pass, int secId, int cId)
        //{

        //}


    }
}
