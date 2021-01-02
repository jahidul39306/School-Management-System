using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Model;

namespace School_Management_System.Controller
{
    public class SectionController
    {
        static Database db = new Database();
        public static Section GetSection(int secId)
        {
            return db.Sections.GetSection(secId);
        }
    }
}

