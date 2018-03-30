using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebAPI.Models
{
    public class Employee
    {
        public string code { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public int HouseNumber { get; set; }
        public string Village { get; set; }
        public string City { get; set; }

    }
}