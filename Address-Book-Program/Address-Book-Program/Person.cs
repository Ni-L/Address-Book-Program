using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Program
{/// <summary>
/// Creating Person Class Using Get,Set Method
/// </summary>
    class Person
    {
        // For Getting And Setting Elements
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public static List<Person> People = new List<Person>();

        //Creating Method 
        public static void AddPerson()
        {
            //Creating Object of Person 
            Person person = new Person();
            //Taking Various Input From User
            Console.WriteLine("Enter First Name :");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter State :");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter Zip :");
            person.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number :");
            person.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address :");
            person.Email = Console.ReadLine();
            //Adding person Details in List
            Person.People.Add(person);

        }
    }
}