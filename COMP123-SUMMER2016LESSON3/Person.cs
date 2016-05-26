using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_SUMMER2016LESSON3
{  
    /**
     * This class defines a generic person
     * 
     * @class Person
     * @field _name {string}
     */


    public class Person
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++
        /**
         * This is a property for our _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }        
            set
            {
                this._name = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        /*public string getName()
        {
            return this._name;
        }
        public void setName(string name)
        {
            this._name = name;
        }*/

        /**
         * This is the default empty constructor for the Person class
         * 
         * @constructor Person
         * 
         */

        public Person()
        {
            this._name = "unknown name!";
        }
        /**
      * This is a constructor that takes name as a parameter and passes 
      * it to the _name private instance variable
      * 
      * @constructor Person
      * @param {string} name
      */

        public Person(string name)
        {
            this._name = name;
        }

        public void SayHello()
        {
            Console.WriteLine(_name + " says hello");

        }

        public void ShowAge()
        {
            Console.WriteLine(_name + " is " + _age + " years old");
        }
    }
}
