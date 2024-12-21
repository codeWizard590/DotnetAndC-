// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

/*
    now i have created a class that means i have a structure of a person
    object is basically the instance of that class .
    which means person1 is an object and neha is another object using the same structure to define their 
    properties .
*/
Person.Human person1 = new();
person1.Name = "ankit";
person1.age = "27";
person1.Id = 1;

// or this can be written as 
Person.Human Neha = new()
{
    Name = "Neha",
    age = "29",
    Id = 2,
};
Person.Members aloto = new Person.Members("120 Km/h", "Alto K10");
person1.greet();
Neha.greet();
aloto.greetmycar();

//checking access modifiers 
//over here name and id are accesisble as they are public so is the method.
Person.ModifierCheck modifierCheck = new()
{
    Id = 1,
    Name = "Ankit dhiman"
};
modifierCheck.publicCheck();

//checking nested private logic
// outer classes cannot be private . 
//nestedPrivate classes can be private
Person.PrivateCheck nestedPrivate = new();
nestedPrivate.resultFromPrivate(2,"Baanke Bihari");

//inheritence and using protected classes with derived classes
Person.InheritProtectedCheck inheritanceCheck = new();
inheritanceCheck.setName("Slim Shady");
inheritanceCheck.showName();

// internal will be accessible across the same assembly or project .

// protected internal -> same assembly and derived classes

inheritanceCheck.showForinternal();
// private internal -> within the class / derived class in the same assembly .
inheritanceCheck.showforprotected();


// OOPS methods 
Oops.Encapsulation encapsulation = new();
encapsulation.depositBalance(2.33M); // m is used to make the compiler understand it is decimal not double 
encapsulation.getBalance();
encapsulation.depositBalance(2.33M);
encapsulation.depositBalance(2.33M);
Console.WriteLine($"this is encapsulation : {encapsulation.getBalance()}");

// check polymorphism
Oops.Polymorphism polymorphism = new();
// method overloading ..
polymorphism.sum(1,2);
// method overriding ..
Oops.Override overding = new();
overding.overriding();
// abstraction -> we can use sealed keyword to stop further overriding in the derived classes 
Oops.AbstractedClass abstraction = new();
abstraction.overriding();
abstraction.display();
//using interfaces
Oops.InhertInterface inheritInterface=new();
inheritInterface.inheritInterface();   
