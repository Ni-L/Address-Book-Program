using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Program
{/// <summary>
/// Creating Class for Adding List and Data
/// </summary>
    class Person
    {
        //Get And Set method to getting and Setting Elements
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        //Creating List to add Person data
        public static List<Person> People = new List<Person>();

    }
}