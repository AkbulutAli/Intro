﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
