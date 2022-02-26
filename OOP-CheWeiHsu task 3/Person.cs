using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task_3
{
    class Person
    {
        //Constructor:
        public Person(string firstName, string lastName, Address shippingAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            ShippingAddress = shippingAddress;
        }
        //overridden version of ToString()
        public override string ToString()
        {
            //You are free to choose what/how to echo the information...
            //return base.ToString();
            return "Person: Firstname: " + FirstName + ", Familyname: " + LastName + "\nShipping Address: " + ShippingAddress;
        }

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string StreetAddress { get; set; }
        //public string City { get; set; }
        //public string PostalCode { get; set; }
        //public string Country { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }


    }
}
