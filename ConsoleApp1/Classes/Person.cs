using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Classes
{
    // this is a class person where we can have multiple members 
    internal class Person
    {

        public class Human
        {

            public int Id { get; set; }
            public string? Name { get; set; }
            public string? age { get; set; }

            public void greet()
            {
                Console.WriteLine($"my name is {Name} , i am {age} years old . my identity is {Id}");
            }
        }

        public class Members
        {
            //a class can have multiple members 
            //Typically, fields are private to follow the principle of encapsulation,
            //which hides implementation details from the outside.
            private string? speed;   //fields 
            private string? name;    //fields

            //constructor to initalize a class
            public Members(string speed, string name)
            {
                Speed = speed;
                Name = name;
            }
            //properties to get and set the fields  -> member 2
            public string Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public void greetmycar()
            {
                Console.WriteLine($"my car is {name} , i am {speed} ");
            }

        }

        //access modifiers
        //- > public : accessible everywhere
        public class ModifierCheck
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public void publicCheck()
            {
                Console.WriteLine($"i am inevitable {Name} find my id at {Id}");
            }

        }
        // -> private : accessible only within the class 
        public class PrivateCheck
        {
            private int Id { get; set; }
            private string? Name { get; set; }

            private void privateCheck()
            {
                Console.WriteLine($"i am inevitable but i am private {Name} find my id at {Id}");
            }

            public void resultFromPrivate(int id, string name)
            {
                PrivateCheck values = new()
                {
                    Id = id,
                    Name = name
                };
                privateCheck();
            }
        }

        /*
         Protected introduces a derived class . 
         this concept is used in inheritence 
         */
        public class ProtectedCheck
        {

            protected string? Name { get; set; }
            protected string? forInternalProtected { get; set; }

            public  void setName(string name)
            {
                Name = name;
            }
            // this is for checking protected internal .
            protected internal void setInternalString(string name)
            {
                forInternalProtected = name;
                Console.WriteLine($"let us check for internal protected method {forInternalProtected } is the name ");
            }

            // this is for checking private protected 

            private protected void getProtectedString(string name)
            {
                Console.WriteLine($"we will check for the private protected {name}");
            }

        }

        public class InheritProtectedCheck : ProtectedCheck
        {
            public void showName()
            {
                //accesible as derived from the derived class . any member can be inherited 
                Console.WriteLine($"my name is real slim shady {Name}");
            }

            // called protected internal method from the class derived 
            public void showForinternal()
            {
                setInternalString("ANKIT PROTECTED INTERNAL STRING PROTECTED");
            }
            // derived class for a private protected getprotected string 
            public void showforprotected()
            {
                getProtectedString("this is get protected string");
            }
        }
    }
}
