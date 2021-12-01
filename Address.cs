using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
 * Rene Lisasi
 * ChattBank
 * October 31,2021
 * I wrote this
 * *****************/

namespace ChattBank
{
    class Address
    {
        //properties
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        /**constructors**/
        //constructor that passes no arguments
        public Address()
        {
            Street = "";
            City = "";
            State = "";
            Zip = 0;
        }

        //constructor that passes all arguments
        public Address(string street, string city, string state, int zip)
        {
            Street = street;
            City = city;
            this.State = state;
            this.Zip = zip;
        }

        /***methods***/
        public void DisplayAddress()
        {
            System.Diagnostics.Debug.WriteLine($"Street: {Street}, City: {City}, State: {State}, Zip: {Zip}");
        }
        public void setStreet(string street) { Street = street; }
        public String getStreet() { return Street; }

        public void setCity(string city) { City = city; }
        public String getCity() { return City; }

        public void setState(string state) { State = state; }
        public String getState() { return State; }

        public void setZip(int zip) { Zip = zip; }
        public int getZip() { return Zip; }

    }
}

