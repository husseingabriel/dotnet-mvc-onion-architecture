﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnionArchitecture.Web.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string IdentityCard { get; set; }
    }
}