using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /// <summary>
    /// Describe a class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Person obj = new Constructor.Person("Bhagath","Kummari");
            Adult obj = new Adult("bhagath","Kummari");
            Constructor c1 = new Constructor();
            
            Console.WriteLine(Adult.minimumAge);
            Console.ReadKey();
            try
            {

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("");
            }
         
        }
    }
    public class Person
    {
        private string last;
        private string first;

        public Person()
        {
            Console.WriteLine("Default Constructor");
        }

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
            Console.WriteLine("the Full Name is {0}{1}", last, first);

        }

        // Remaining implementation of Person class.
    }
    public class Adult : Person
    {
        public static int minimumAge;

        public Adult(string lastName, string firstName) : base(lastName, firstName)
        {
            Console.WriteLine("Adult overloaded constructor");
            
            
        }

        static Adult()
        {
            minimumAge = 18;
        }
        public Adult()
        {

        }

        // Remaining implementation of Adult class.
    }

}
