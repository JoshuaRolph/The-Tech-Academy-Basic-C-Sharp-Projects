﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CodeFirstApplication
{
    class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
