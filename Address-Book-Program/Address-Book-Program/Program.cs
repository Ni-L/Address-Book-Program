using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Program
{/// <summary>
/// Main Method Adding Data Manually
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****WelCome TO Address Book*****");
            //Creating Object
            ContactDetails person = new ContactDetails("Nilima", "Wadal", "Chhotta", "Akola", "Maharashtra", "444101", "9130264839", "nilimawadal@gmail.com");
            //Calling all Data
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            Console.Read();

        }
    }
}
