using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_SUMMER2016LESSON3
{
    /*This cass is the "driver" class for our Program
     * 
     * @class Program
     */
   public class Program
    { /**
       *the main method for our driver class Program
       * 
       * @method Main
       * @param {string[]} args
       * 
       */ 
       
        public static void Main(string[] args)
        {

            // create a new Instance of the Person class

            Person person = new Person("Johaen");

            Console.WriteLine(person.Name);

            // set a value in the Name property of the Person class
            person.Name = "Johaen";
            person.Age = 47;
            //get the Name value and print to console
            Console.WriteLine(person.Name);
            person.SayHello();

            person.ShowAge();

        }
    }

}
