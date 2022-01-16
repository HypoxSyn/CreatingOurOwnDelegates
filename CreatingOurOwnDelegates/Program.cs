using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingOurOwnDelegates
{
    class Program
    {
        //Delegate Practice
        public delegate bool FilterThis(Person p);

       
        static void Main(string[] args)
        {
            MethodList.CallMethods(); //testing the ability to call multiple methods


            //Create objects of the Person class
            Person p1 = new Person() { Name =   "Sam",  Age = 41 };
            Person p2 = new Person() { Name = "Carey",  Age = 14 };
            Person p3 = new Person() { Name = "Kahne",  Age = 13 };
            Person p4 = new Person() { Name = "Carey",  Age = 35 };
            Person p5 = new Person() { Name = "Rosco",  Age = 52 };
            Person p6 = new Person() { Name = "Manny",  Age = 72 };
            Person p7 = new Person() { Name = "Caree",  Age = 88 };

            //Store the Person objects in a List called People

            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5, p6, p7 };

            DisplayPeople( "Minors"  ,  people, IsMinor);
            DisplayPeople( "Adults"  ,  people, IsAdult);
            DisplayPeople( "Seniors" ,  people, IsSenior);
            DisplayPeople( "IsPerson",  people, IsCarey);

        }

        static void DisplayPeople(string title, List<Person> people, FilterThis filter)
        {
            Console.WriteLine(title);
             
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old.");
                }
            }

            Console.WriteLine("");

        }

        

        //Methods for the FilterDelegate delegate to use
        static bool IsMinor  (Person p) => p.Age < 17;
        static bool IsSenior (Person p) => p.Age >= 65;
        static bool IsAdult  (Person p) => p.Age >= 18;
        static bool IsCarey  (Person p) => p.Name == "Carey";
        
    }
}
