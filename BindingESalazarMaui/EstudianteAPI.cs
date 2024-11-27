﻿using Android.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingESalazarMaui
{
    public class EstudianteAPI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<string> Courses { get; set; }
        public double Gpa { get; set; }
        public string Image { get; set; }
    }
}