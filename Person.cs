using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 * Rene Lisasi
 * Chattbank
 * Nov 2,2021
 * I wrote this
 * *****************/
namespace ChattBank
{
    class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Address Address { get; set; }
        public string Email { get; set; }

        //constructor that takes no agruments
        public Person()
        {
            FirstName = "";
            LastName = "";
            Address = new Address();
            Email = "";

        }

        //constructor that takes agruments
        public Person(string fname, string lname, Address address, string email)
        {
            FirstName = fname;
            LastName = lname;
            //Address = address;
            Email = email;
            Address = address;
        }

        public static String generatePw()
        {
            String a = "";
            Random r = new Random();
            int rInt = r.Next(0, 99); //for ints*
            a = rInt.ToString();
            return a;
        }

        public void setFirstName(string fn) { FirstName = fn; }
        public String getFirstName() { return FirstName; }

        public void setLastName(string ln) { LastName = ln; }
        public String getLastName() { return LastName; }

        public void setEmail(string email) { Email = email; }
        public String getEmail() { return Email; }
        public void Display()
        {
            //diplay to console
            System.Diagnostics.Debug.WriteLine($"First Name: {FirstName} Last Name: {LastName} Address: {Address.ToString()} Email: {Email}");
            Address.DisplayAddress();
        }//end display
    }
}

