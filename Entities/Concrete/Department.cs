﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Department
    {
        public Department()
        {

        }
        public Department(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
