﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Model;

namespace School_Management_System.Controller
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string userName, string password)
        {
            return db.Admins.AuthenticateAdmin(userName, password);
        }

    }
}
