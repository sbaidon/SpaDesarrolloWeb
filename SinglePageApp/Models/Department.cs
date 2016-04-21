﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageApp.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }

    }
}