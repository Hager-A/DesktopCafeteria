﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Employee
    {
        public int Id { get; set; }
        public string Email{get; set;}
        public string Name{get; set;}
        public string Password { get; set; }
        public string Role {  get; set;}
        public List<Order> Orders { get; set; }
    }
}
