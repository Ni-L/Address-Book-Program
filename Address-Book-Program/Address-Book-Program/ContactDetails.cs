using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Program
{/// <summary>
/// Contact Details
/// </summary>
    class ContactDetails//default constructor
    {
        //Declaring Variables
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        string phoneNumber;
        string email;

        //Creating method Constructor 
        public ContactDetails(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            //Instance Variables
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        //Get method for getting the Elements
        public string getName()
        {
            return this.firstName;
        }
        public string getlastName()
        {
            return this.lastName;
        }
        public string getaddress()
        {
            return this.address;
        }
        public string getcity()
        {
            return this.city;
        }
        public string getstate()
        {
            return this.state;
        }
        public string getzip()
        {
            return this.zip;
        }
        public string getphone()
        {
            return this.phoneNumber;
        }
        public string getemail()
        {
            return this.email;
        }
        //Adding Tostring method To storing data 
        public string Tostring()
        {
            return "First Name:" + firstName + "\nLast Name:" + lastName + "\nAddress:" + address + "\nState:" + state + "\nCity:" + city + "\nZip:" + zip + "\nPhoneNumber:" + phoneNumber;

        }

    }
}