using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fi-FI");//更換國籍鍵盤的指令
            //create an object of class Student:

            //Console.Write("Enter Firstname: ");
            //string firstname = Console.ReadLine();
            //Console.Write("Enter Familyname: ");
            //string familyname = Console.ReadLine();
            //Console.Write("Enter Birthday: ");
            //string isThisValid = Console.ReadLine();
            //DateTime dateofbirth;
            //while (!DateTime.TryParse(isThisValid, out dateofbirth))
            //{
            //    Console.Write("Not valid, try again: ");
            //    isThisValid = Console.ReadLine();
            //}

            //Now you should have it all!
            //Create the object

            //Student student = new Student(firstname, familyname, dateofbirth);
            //Console.WriteLine(student);
            //student.CalculateAge();



            //Console.ReadLine();

            //You can make this interactive, but for now...
            //Create an instance of class Address:

            Address addressOfPerson = new Address("Sammonkatu 10", "Mikkeli", "50190", "Finland");//這四項中缺一不可，也不可多，因為在Address的Constructor中就是四項

            //Create an instance of class Person

            Person student = new Person("Matti", "Juutilainen",addressOfPerson);

            //what comes out?
            Console.WriteLine(student);

            Address addressOfCompany = new Address("Jämeräntaival 11","Espoo","02150","Finalnd");
            Company company = new Company("Advanced Software Solutions", addressOfCompany);
            Console.WriteLine(company);
        }
    }
}
