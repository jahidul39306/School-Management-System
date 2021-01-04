using System;
using System.Collections;
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
        public static int GetTotalSection()
        {
            return db.Sections.GetTotalSection();
        }
        public static bool AddSection(Section s)
        {
            return db.Sections.AddSection(s);
        }
        public static ArrayList GetAllSections()
        {
            return db.Sections.GetAllSections();
        }
        public static ArrayList SearchSectios(string search)
        {
            return db.Sections.SearchSectios(search);
        }
    }
}

