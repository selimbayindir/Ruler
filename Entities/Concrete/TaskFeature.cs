﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class TaskFeature : IEntity
    {
        public TaskFeature()
        {

        }
        public TaskFeature(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

    }
}
