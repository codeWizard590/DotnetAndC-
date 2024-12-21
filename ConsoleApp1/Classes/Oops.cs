using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Oops
    {
        //encapsulation 
        //encapsuation is about bundling data and functions together in a class 
        //direct access to some of the object's components is restricted 
        //Hide sensitive data(use private or protected).
        //Expose data safely via public properties or methods.
        internal class Encapsulation
        {
            //the balance field is restriced to access i.e. private 
            private decimal balance;

            // to modify the balance field i will introduce a method to change and retrieve balance 

            public void depositBalance(decimal depBalance)
            {
                if (balance >= 0)
                {
                    balance += depBalance;
                }
            }

            public decimal getBalance()
            {
                return balance;
            }
        }

        // inheritence and basics 
        //  basically allows a class to inherit properties from another class / derived class 
        internal class Inheritence
        {
            public class Animal
            {
                public void eat()
                {
                    Console.WriteLine("i am sure animals Eat");
                }
            }
            public class Dog : Animal
            {
                public void sound()
                {
                    Console.WriteLine("i am sure animals do have sounds");
                }
            }
        }

        internal class Polymorphism
        {
            public int a;
            public int b;
            public int c;
            private int polymorphisedSum = 0;
            public void sum(int a, int b)
            {
                polymorphisedSum = a + b;
                Console.WriteLine($"polymorphised sum is {polymorphisedSum}");
            }
            public void sum(int a, int b, int c)
            {
                polymorphisedSum = a + b + c;
                Console.WriteLine($"polymorphised sum is {polymorphisedSum}");
            }

            //Methods that are not described as virtual , abstract and override can not be overridden. 
            public virtual void overriding()
            {
                Console.WriteLine($"override this class with the child method -> this is parent class");
            }
        }
        internal class Override : Polymorphism
        {
            //virtual Classes being overriden by override class
            public override void overriding()
            {
                Console.WriteLine($"this is child class overridden by inheritence polymorphism");
            }
        }

        // abstraction ->
        public abstract class Abstraction
        {
            public abstract void overriding(); //abstract method
            public void display()
            {
                Console.WriteLine($"displaying method in abstracted class");
            }

        }
        public class AbstractedClass : Abstraction
        {
            public override void overriding()
            {
                Console.WriteLine($"abstract method displayed by overriding and has no implementation in the base class ");
            }
        }

        public interface Iinterface
        {
            void inheritInterface(); // in interface we donot define logic 
        }
        public class InhertInterface:Iinterface
        {
            public void inheritInterface()
            {
                Console.WriteLine($"example of interface inhertiance in abstraction");
            }
        }
    }
}
