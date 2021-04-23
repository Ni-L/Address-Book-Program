using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Program
{/// <summary>
/// Main Method 
/// </summary>
    class Program
    {/// <summary>
     /// Calling Methods 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("*****WelCome To The Address-Book*****");
            //Calling AddPerson Method
            Person.AddPerson();
            Person.AddPerson();
            //Initialized For Loop for Printing Each Details of person
            foreach (var i in Person.People)
            {
                //Print And Store Data
                Console.WriteLine(i.FirstName + "  " + i.LastName + "  " + i.Address + "  " + i.City + "  " + i.State + "  " + i.Zip + "  " + i.State + "  " + i.Email);
            }
            Console.WriteLine("Please Enter the Name You Want to Edit : ");
            string userinput = Console.ReadLine();
            //Initialized For Loop for Editing with FirstName
            foreach (var j in Person.People)
            {
                //If True Then Edit
                if (j.FirstName == userinput)
                {
                    //Editing From FirstName Data
                    Console.WriteLine("Edit LastName :");
                    //Realine Edited Data
                    j.LastName = Console.ReadLine();
                    Console.WriteLine("Edit Address :");
                    j.Address = Console.ReadLine();
                    Console.WriteLine("Edit City :");
                    j.City = Console.ReadLine();
                    Console.WriteLine("Edit State :");
                    j.State = Console.ReadLine();
                    Console.WriteLine("Edit Zip :");
                    j.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Edit Phone Number :");
                    j.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Edit Email :");
                    j.Email = Console.ReadLine();
                    Console.WriteLine("Address Book After Edited");
                }
                else
                {
                    //If False then Print
                    Console.WriteLine("Such Entries Are not Found");
                }//End of If ElseLoop

            }//End of If Loop
            //After Editing Contact Will Be
            foreach (var i in Person.People)
            {
                Console.WriteLine(i.FirstName + "  " + i.LastName + "  " + i.Address + "  " + i.City + "  " + i.State + "  " + i.Zip + "  " + i.State + "  " + i.Email);
            }
            //End of If Loop
            Console.Read();
        }
    }
}
