using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Model;
namespace School_Management_System.Controller
{
    public class ClassController
    {
        static Database db = new Database();
        public static Clas GetClass(int cId)
        {
            return db.Classes.GetClass(cId);
        }
    }
}
