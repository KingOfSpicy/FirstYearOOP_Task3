using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task_3
{
    class Address//在這個Address把游標放入，ALT+ENTER 就可以自動生成Constructor了! //輸入ct也是可以，但效果不如預期(無內容物)

    {
        //Constructor; could be many of them...
        public Address(string streetAddress, string city, string postalCode, string country)
        {
            StreetAddress = streetAddress;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
        public override string ToString()//在顯示ToString以後，一樣可以Tab自動生成
        {
            //return base.ToString();
            return "Street: " + StreetAddress + ", City: " + City + "\nPostal Code: " + PostalCode + ", Country: " + Country;
        }

        //Properties:
        public string StreetAddress { get; set; }//(先輸入pro 自動顯示後，按下Tab兩次，電腦會自動生成properties)
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
