using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Program
{/// <summary>
/// Main Method To call Methods
/// </summary>
    class Program
    {
        static void Main(string[] args)
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
            //Initialized For Loop for Printing Each Details of person
            foreach (var i in Person.People)
            {
                Console.WriteLine(i.FirstName);
                Console.WriteLine(i.LastName);
                Console.WriteLine(i.Address);
                Console.WriteLine(i.City);
                Console.WriteLine(i.State);
                Console.WriteLine(i.Zip);
                Console.WriteLine(i.Email);
            }//End of For Loop
            Console.Read();
        }
        
       
    }
}
