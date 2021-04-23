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
            //WriteLine for UserInputs
            Console.WriteLine("Please Enter the Name You Want to Edit : ");
            string userinput = Console.ReadLine();
            //Initialized For Loop for Editing with FirstName
            foreach (var j in Person.People)
            {
                //Initialized if Loop For Finding Name
                //If True Then Edit
                if (j.FirstName == userinput)
                {
                    Person.People.Remove(j);
                    break;

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