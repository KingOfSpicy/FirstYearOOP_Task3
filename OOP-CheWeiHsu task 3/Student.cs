using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task_3
{
    class Student
    {
        //Auto-Implemented Properties
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student(string firstName, string familyName, DateTime dateOfBirth)
        {
            //游標放在開頭的Student上，按下ALT+ENTER 直接跑出Constructor
            FirstName = firstName;
            FamilyName = familyName;
            DateOfBirth = dateOfBirth;
        }
        //override ToString();
        public override string ToString()
        {
              //return base.ToString();
              return $"Firstname is {FirstName}, Familyname is {FamilyName}, Birthday is {DateOfBirth.ToLongDateString()}";
        }

        public void CalculateAge()
        {
            //Today is...
            DateTime thisDay = DateTime.Now;
            int numberOfYears = 0;
            while(thisDay.CompareTo(DateOfBirth.AddYears(numberOfYears))>=0)
            {
                numberOfYears = numberOfYears + 1;
            }
            numberOfYears = numberOfYears - 1;
            //ternary operator:
            int numberOfMonths = 0;
            while(thisDay.CompareTo(DateOfBirth.AddYears(numberOfYears).AddMonths(numberOfMonths)) >= 0)
            {
                numberOfMonths = numberOfMonths + 1;
            }
            numberOfMonths = numberOfMonths - 1;
            int numberOfDays = 0;
            while (thisDay.CompareTo(DateOfBirth.AddYears(numberOfYears).AddMonths(numberOfMonths).AddDays(numberOfDays)) >= 0)
            {
                numberOfDays = numberOfDays + 1;
            }
            numberOfDays = numberOfDays - 1;

            string singularPluralY = numberOfYears <= 1 ? "year" : "years";
            string singularPluralM = numberOfMonths <= 1 ? "month" : "months";
            string singularPluralD = numberOfDays <= 1 ? "Day" : "Days";
            //string singularPluralM = numberOfMonths == 1 ? "month" : "months";//等於等於變成小於等於



            Console.WriteLine($"You are {numberOfYears} {singularPluralY}, {numberOfMonths} {singularPluralM}, {numberOfDays} {singularPluralD} years old now.");
            Console.WriteLine("Today is "+ thisDay.ToLongDateString());
        }
        

        
    }
    
}
    