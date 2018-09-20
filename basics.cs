using System; //system is namespace, a group of classes. One of those classes is console.
using System.Collections.Generic; //needed for Lists and Dictionaries

namespace myApp //the namespace doesn't appear to be necessary but I think it typically used. 
{
    class Program
    {
        static void Main(string[] args) 
        {
            // What is C# and .net?
            // C# is the programming language and .net is a windows app framework 
            // .net includes CLR, which is what takes the code from IL (intermediate language)
            // to native code for particular hardware. The CLR is the runtime environment. 
            // That means c# programs are first compiled to IL but then get compiled again to
            // machine code at runtime (JIT) using the CLR. That makes C# programs platform independent. 
            // .net also includes a class library that is useful for building applications. 

            // architecture of .net apps 
            // every file gets its own class
            // folders are for namespaces. For the main method to find classes in a namespace, you must write
            // "using namespaceFolder" at the the top of it's file. 
            // subfolders in a namespace can also be used. To locate those subfolders the using statment looks
            // like this: using namespaceFolder.subFolder
            // classes are grouped together in namespaces
            // namespaces are typically for 10s of related classes
            // namespaces are grouped together in an assembly, which is a file, either a .dll or a .exe
            // a full application consists of one or more assemblies 

            //---------------------------------------
            // C# style conventions
            // class names, properties, and methods all use pascal case
            // private fields use camelcase with an underscore
            // method parameters also use camelcase

            //---------------------------------------
            // variables and constants
            // const int myNum = 5;
            // string myNum = 5;
            // PascalCase for constants, camelCase for variables

            // primitives
            // theses are structs, not classes
            // there are few different integer types, real number types,
            // character and boolean. The default type for a real number
            // is double, so you have to be explicit about creating a 
            // float or decimal.
            // float myFloat = 125f;
            // char letter = 'a';
            // string name = "obie"; strings are not a struct, they are a class
            // use var for implicit data types
            // var dog = "obie";

            // console writeline a formated string
            // var name = "obie";
            // var age = 6;
            // System.Console.WriteLine("{0} {1}", name, age);

            //---------------------------------------
            // implicit and explicit type conversion
            // byte b = 1;
            // int i = b;
            // Here, the byte b is copied to an integer. The difference between a byte 
            // and an int is just how much memory is allocated. A byte allocates 1 byte 
            // and an int allocates 4 bytes. That means an implicit conversion of byte 
            // is no problem because an int always has space for a byte. However, that 
            // conversion will not work in the other direction. To force the coversion
            // explicitly casting is needed. Casting may result in data loss if the int
            // is too large.
            // double number = 3000;
            // byte b = (byte)number; //casting with data loss. b = 184 because a byte can't hold
            // // 3000

            // convert string to int
            // string s = "1";
            // int i = Convert.ToInt16(s); // convert is a class in system namespace
            // System.Console.WriteLine(i);

            //---------------------------------------
            // operators - 5 types
            // arithmetic, comparison, assignment, logical, bitwise
            // they all seem about the same as js. bitwise is advanced and not covered

            //--------------------------------------
            // arrays 
            // arrays hold a fixed number of variables of a particular type
            // int[] numbers = new int[3] { 1, 2, 3 };

            //----------------------------------------
            // strings
            // the string data type comes from the string class in the .net framework
            // they include many common methods like .ToUpper, .ToLower, and .Trim, IndexOf, Substring, etc
            // String.IsNullOrWhiteSpace() is often used for validation

            // many string methods are static methods on the string class, which suggests
            // that static methods are available on objects (instances) as well as classes? 

            // concatenation
            // var name = "obie";
            // var action = "runs fast";
            // System.Console.WriteLine(name + " " + action);
            // there are a few other ways to concatenate strings too

            // strings are immutable but there are methods to change strings - they just
            // return a new string 
            // string name = "obie";
            // to create strings that you want to change, use the StringBuilder class from system.text
            // StringBuilder is a mutable string
            // it includes methods like Append, Insert, Remove, Replace, Clear
            // StringBuilder methods return a StringBuilder, which means you will often chain many methods
            // together - it looks the same as chaining in js

            //-----------------------------------------
            // enum 
            // a set of name/value pairs
            // basically a collection of constants in something similar to a class
            // hard to explain...and I don't really understand

            //--------------------------------
            // reference types vs value types
            // everything is either a struct or a class. All primitives are structs
            // structs have automatic memeory managment on the stack
            // classes require explicit memory allocation but are automatically garbage
            // collected
            // structs are copied by value and classes are copied by reference 
            // this copying issue is identical to js 

            //---------------------------------------
            // control flow
            // If else, case switch, ternary, for loops, while loops, break and continue statements 
            // are exactly the same as js
            // foreach will iterate over arrays or strings or anything list like 
            // foreach(var number in numbers){};
            // do while are just while loops where the condition is evalutated at the end
            // do
            // {
            //     ...
            //     i++
            // } while (i < 10)

            //---------------------------------------------------
            // Arrays
            // single dimensional array initialization 
            // var numbers = new int[5] { 1, 2, 3, 4, 5 };
            // multidimensional arrays 
            // there are 2 types - rectangular and jagged
            // jagged arrays mean that each row is an array of different length 
            // jagged arrays are an array of arrays. 
            // There is a slight performance advantage of jagged over rectanglular
            // rectangular arrays are matrices 
            // var matrix = new int[3, 5] //3 is the row and 5 is the column 
            // initialize a matrix
            // var matrix = new int[3, 5]{
            //       {1,2,3,4,5},
            //       {1,2,3,4,5},
            //       {1,2,3,4,5}
            //   };
            // initialize a jagged array of arrays 
            // var jagged = new int[3][] //3 jagged rows are initialized 
            // jagged[0] = new int[5]
            // jagged[1] = new int[3]
            // jagged[0] = new int[5]

            // array methods
            // some are accessible from Array class (static) method and others are 
            // accessible from array instance (instance methods)
            // length, indexof, clear, copy, sort, reverse 
            // int[] numbers = { 1, 2, 3, 5, 4, 6, 7, 8, 9 };
            // Console.WriteLine(numbers.Length); //9
            // Console.WriteLine(Array.IndexOf(numbers, 3)); //2
            // Array.Clear(numbers, 1, 1); //removes the first index, replacing it with 0 by default. 
            // var numbersCopy = new int[9];
            // Array.Copy(numbers, numbersCopy, 9); //copies all 9 elements into a new array 
            // Array.Sort(numbers); //sorts the array
            // Array.Reverse(numbers); //reverses the array

            //----------------------------------------------
            // lists 
            // lists are almost always preferred over arrays. Expect for everything to be done
            // with lists.
            // lists don't require a predetermined length
            // var numbers = new List<int>() { 1, 2, 3, 4 };
            // lists have a bunch of methods like add, remove, count, contains, indexof, etc. 

            // -------------------------------------------
            // 2 date types - DateTime and TimeSpan
            // subtracting 2 DateTimes will result in a TimeSpan
            // but I think you have to use the .subtract method 
            // on DateTimes

            // var dateTime = new DateTime(1984, 4, 19);
            // var today = DateTime.Today;
            // var age = today - dateTime;

            // System.Console.WriteLine(age.TotalDays);
            // System.Console.WriteLine(age.ToString());
            // System.Console.WriteLine(today.ToShortDateString());
            // System.Console.WriteLine(today.ToString("yyyy-MM-dd"));

            //---------------------------------------------------
            // file system 
            // the classes for working with the file system are located in 
            // System.IO
            // 
            // as you should expect, there are classes for interactng with files,
            // directories, and path 
            // files and directories each have 2 classes - one class for static methods 
            // and one class for instance methods. For example, files can be manipulated
            // the File class or the FileInfo class. The file class has static methods 
            // and the FileInfo class has instance methods. The reason for this distinction is that
            // file methods are more convienient (you dont have to make an instance) but they
            // are costly because of security checks that run every time the method is called. 
            // FileInfo methods also have a security check but that only occurs once, at the time 
            // the instance is created. 

            //--------------------------------------------
            //end of course 1
            //-------------------------------------------

      // Constructors
                  
      // constructors are methods called when an object is created
      // they put the object into an inital state
      // A constructor is identified by the compiler by having the same name as the class 
      // The constructor doesn't return a type, not even a void.
      // if you don't include a constructor, the compiler still runs one for you. That 
      // constructor will set inital values according to these rules: numbers are 0, strings 
      // and other reference types are null, booleans are false, chars are empty character

      // null reference exceptions
      // I think these are the same as null pointer exceptions? 
      // the problem is that all reference types are initalized to null when they aren't 
      // explicitly initialized in the constructor. An example is with a list. Imagine a list
      // used to store new orders. If that list isn't initialized to a new List, then it will be 
      // null when the first order is tries to add itself to the list. That is a null reference 
      // exception. 

      // overloading
      // overloading a constructor is when multple methods of the same name but different 
      // signatures (parameters) are written 
      // Unlike js, in C#, function parameteters and return values must be specified in advance
      // Overloading is how one method can have many different versions without the need for the method
      // to be unreadably complex.   

      // there are many style issues that come up with overloading because it is possible to write 
      // ugly code full of redundancy. There is a technique using a special this keyword that allows 
      // for other method signitures to be called beforehand. You can think of this technique as chaining
      // together calls to multiple signitures of an overloaded constructor. 

      //-------------------------------------------------

      // Object initalizers
      // these are a shorthand instead of using constructors. 
      // they help you set certain property values at the time of object instantiation without 
      // having to include constructors in the class for doing so. 
      // the syntax for doing this is quite similar to an object literal in js
      //-----------------------------------------------------
      
      // Params Modifier 
      // What if you want to create an add method that takes an arbitrary number of 
      // parameters? 
      // you can pass an int[] to the add method but that requires creating a new int[] on 
      // the fly which is a little ugly as a method argument
      // the params modifier is the right solution 
      // here is what the add signature would look like 
      // public int Add(params int[] numbers){}
      // now Add can be called like this: 
      // Add(1, 2, 3)
      // instead of this: 
      // Add(new int[]{1, 2, 3})   
      //-----------------------------------------------------------

      // fields
      // fields are private variables 
      // proper style is to use _camelCase.
      // these fields can be initalized with a constructor or they can be initalized 
      // directly by simply assigning a value to a field after its declaration
      // Whether you do this or use constructors is a matter of style. I like the idea 
      // of only using a constructor if its arguments come from the instantiation of new 
      // objects. 

      // ---------------------------------------
      // Properties
      // the purpose of properties is to encasulate private fields with a getter and setter
      // you don't want to have to write a separate private field, getter, and setter ever 
      // time you want to create a private variable.
      // there are 2 ways to create a property 
      // if the getter and setter contains no logic other than simply getting and setting, 
      // you can use an auto implemented property
      // public DateTime Birthdate { get; set; }
      // otherwise, a property still requires declaring a private field 
      // private DateTime _birthdate;
      // public DateTime Birthdate
      // {
      //     get { return _birthdate; }
      //     set { _birthdate = value; }
      // }

      // what if a field should be set once but you want to use a auto implemented property?
      // it seems that an auto implemented property requires both a getter and a setter 
      // to be declared. The setter would need to be declared as private. The field would 
      // then be assigned with a constructor.

      //--------------------------------------
      // dictionaries and indexers

      // dictionaries are a generic data structure used for storing key value pairs
      // declare and initalize a private dictionary like this:
      // private Dictionary<string, string> _dictionary = new Dictionary<string, string>();
      // indexers are like properties for dictionaries
      // you could use a getter and setter on a dictionary but an indexer is cleaner
      // an indexer is written very similarly to a property 
      // public string this[string key]
      // {
      //     get { return _dictionary[key]; }
      //     set { _dictionary[key] = value}
      // }
      // The indexer allows you to interact with the data structure very much like you would
      // with a js object. 
      // var cookie = new HttpCookie();
      // cookie["name"] = "Obie"; //sets the name key to obie
      // System.Console.WriteLine(cookie["name"]); //gets the value from the name key

      // -------------------
      // Inheritance
      // "is a" relationships between classes use inheritance
      // a car is a vehical, a dog is a mammal 
      // in terms of classes, children can only have one parent
      // the child specifies their parent like this
      // public class ChildClassName : ParentClassName {}
      // The child will inherit everything from the parent, as well
      // as from the ultimate parent class for all other classes, the 
      // Object class.

      // Composition
      // "has a" relationship between classes
      // one class contains another as a private field
      // So a class is composed, in part, of other classes. I think
      // this implied a class design where classes are created with 
      // different levels of specificity/gnerality. The more general 
      // purpose classes are composed, in part, of more specific classes

      // animal example
      // It is temping to think in terms of "is a" relationships with
      // animals. Dog is a animal, for example. However, it is better to 
      // say Dog has a Animal, as strange as that seems. Imagine that animal
      // only has attributes and methods common to all animals - like age.
      // then you could add classes like Walkable and Swimmable. That
      // way, Dog could be composed of Animal and Walkable whereas Fish
      // could be composed of Animal and Swimmable.

      //----------------------------------------
      // More Access Modifiers 
      // already covered public and private 
      // It seems to me that attributes and methods could be accessed
      // in three different ways. One is from within the class itself,
      // another is off the class directly (static methods), and the 
      // other is from an object instance. Public allows member access from 
      // all three. Private only allows access from within the class 
      // itself.

      // protected 
      // allows access from within the class itself and any derived classes
      // this is generally not a good idea because it breaks 
      // encapsulation and creates dependency. Only use protected 
      // very intentionally. There are some design patterns that use 
      // protected.

      // internal
      // this is a access modifier for an entire class. It keeps the 
      // class private to an entire aassembly. Think of it as a 
      // class that is private to a library - part of the 
      // implementation detail of a library.

      // protected-internal
      // this is a combination of protected and internal but it is
      // almost never used so dont worry about it

      //--------------------------------------------
      // constuctors and inheritance
      // what if you instantiate a class that inherits from another?
      // imagine Car inherits from vehicle and vehicle has a 
      // private field for registration number.
      // if you instantiate car, how do you get a registration number?
      // Vehicle's constuctor isnt inherited by car. Also, Car's constructor
      // doesn't have access to vehicle's reg number because it is a private field. 
      // What you need to do is call the constructor in Vehicle
      // when Car is instantiated. This is done with a special syntax
      // in the Car class. It is similar to using super() in js classes.
      //   public class Car : Vehicle {
      //       public Car(string registrationNumber)
      //       : base(registrationNumber)
      //       {
      //           //initialize Car fields here
      //       }
      //   }
      // What if Vehicle had a parameterless constructor? Would you still
      // need to use base()? No, a parameterless constructor would be called
      // automatically (and first) when Car is intantiated. 

      // When Car is instantiated, is Vehicle instantiated? Yes, and its 
      // constuctor is called automatically as long as it is parameterless.
      // if the constructor takes parameters, then base() must be called 
      // in Car's constructor.

      //-----------------------------------------------
      // Upcasting and downcasting
      
      // upcasting 
      // object types are the classes they instantiate. Just like any variable,
      // their types can be changed (casted).
      // upcasting means that an instance of a child class is casted to the 
      // parent class. This can be done easily and implicitly because the original
      // object remains in memory. Remember that a object is copied by reference. 
      // In addition, all the same members remain on the original object in 
      // memory. The only change is that access is restricted such that only the 
      // parent members are accessible. 
      // why do this?
      // I'm not really sure but it is a commom practice and has to do with 
      // polymorphism.

      // downcasting
      // downcasting is when a an object instantiated from a parent class is 
      // casted to a child class type. I don't understand this well or why it 
      // is even useful. 

      // -------------------------------------------
      // Boxing and unboxing

      // boxing is the process of converting a value type instance to an object
      // reference
      // remember that an important difference between reference types and value
      // types is that value types are stored on the stack and garbage collected
      // quickly. Reference types are stored on the heap and are not garbage collected
      // so quickly. 
      // So boxing is when a value type is turned into a reference type and the reverse
      // for unboxing. 

      // An example  of where this matters is with an ArrayList. ArrayLists are arrays
      // that can take any type element. There are a few problems with doing that so 
      // Mosh recommends always using Lists, since lists have elements of all the same
      // type. One of those problems is that there is some boxing going 
      // on because all elements get casted to an Object type, which is a reference type. 

      //----------------------------------------------
      // Polymorphism

      // method overriding
      // modifying the implementation of an inherited method. 
      // notice that this is different from method overloading
      // in order to override a method, the method to be overridden in the super 
      // class needs to have the keyword virtual
      // the subclass method then gets the keyword override
      // e.g. public virtual void Draw(){} or public override void Draw(){}

      // example of polymorphism
      // imagine a shape class that is the super class to cirle and rectangle classes
      // then imagine a drawshapes class that contains a method that can loop through
      // a list, drawing each shape that is held in the list.
      // the shape class has a method called draw that does nothing
      // the sub classes, rectangle and circle, overide that draw class with methods
      // also called draw but particular to their respective needs. When the drawshapes
      // function on the drawshapes class runs, it will loop through a list of shapes
      // and call shapes.draw() on each of them. Because of polymorphism, the overider
      // functions will be called and each shape type will have their own special function called. 

      // Abstract classes and members
      // The abstract modifier is an altenative to the virtual modifier. It allows method
      // overriding but also enforces a number of best practices. I believe the abstract 
      // modifier is preferred over virtual for that reason. 

      // More formally, the abstract modifier indicates that a class or member is
      // missing implementation.
      // the shape class and draw method example is a good time for the abstract modifier 
      // here is the notation for shape
      // public abstract class Shape 
      //{
      //     public abstract void Draw();
      //}
      // Particular shape classes, such as Circle, would have a draw method with the override 
      // modifier
      // There are a few extra restictions with abstract classes. Shape.draw() cant contain 
      // any implementation whatsoever (it can contain some implementation with virtual). 
      // Abstract classes can never be instantiated. 

// ------------------------------------------------------- 
// Interfaces
// interfaces are used for creating loosley coupled classes for testability and 
// extensibility. 

// public interface ITaxCalculator
// {
//      int Calculate();
// }
// interfaces do not have implementation. 

// the purpose of interfaces is to help build loosely coupled apps 
// what does a dependency really mean? In OOP, it means that one class has another class as
// its field or property. Say class A depends on class B. If B changes, A may have to change
// to accomodate. If C is then dependent on A, then C may also have to change. 
// Interfaces solve the dependency problem because B wouldn't be a field or property in A, only 
// the interface to B would be on A. The implementation details of B are irrelavant to A. All
// A cares about is communicating with B through IB. 

// We went through an example where of an app that processed orders. There was a ShippingCalculator
// class as well as a OrderProcessor class and an Order class. The idea was that a new Order was 
// created and processed through the OrderProcessor in order to do a number of things but the relavant
// one was to calculate shipping. When a new OrderProcessor was created, a new Shipping calculator was
// instantiated inside of it. That caused a tight coupling problem because OrderProcessor was 
// very dependent on ShippingCalculator. The solution only partially makes sense to me. It was to 
// have ShippingCalculator be replaced by IShippingCalculator. The way that was done was to write the 
// interface in the same file as ShippingCalculator. Then, ShippingCalculator and IShippingCalculator
// were linked with special bit of syntax that looked similar to what is used for inheritance.
// In the end, instances of ShippingCalculator were removed from the OrderProcessor class and replaced
// with IShippingCalculator. This somehow made unit testing much easier. The actual instance of 
// ShippingCalculator was passed into OrderProcessor as an argument in the main method. 

// Interfaces and extensibility (open closed principle )
// Imagine a DbMigrator class with a migrate() method.
// The migrate method would do many things but one of them is logging. 
//  Perhaps you want to log to the console or perhaps you want to log 
// to a file. 
// Bad design would be to have the console or file choice hard coded into the 
// migrator method. 
// Good design is to have the migrator class program to an interface, ILogger. 
// Ilogger would have logging methods with no implementation. 
// Other classes, like FileLogger and ConsoleLogger, would contain the implementation. 
// They would look like this: 
// public class ConsoleLogger: ILogger
// {
//   public void LogError(){...}
//   public void LogInfo(){...}
// }
// Finally, in the main method: 
// var dbMigrator = new DbMigrator(new FileLogger(...))
// dbMigrator.Migrate()
// This code would use the FileLogger implementation of the ILogger interface in the
// migrate method. 
// If, instead, you wanted the ConsoleLogger implemention: 
// var dbMigrator = new DbMigrator(new ConsoleLogger(...))
// dbMigrator.Migrate()

// The open closed principle says that software should be open for extension but closed
// for modification. Using the ILogger interface accomplishes this goal. DbMigrator never
// needs to be modified but its functionality can be extended by adding new classes that 
// implement Ilogger in new ways. 
// Don't take this principle as too much of a rule. There must be times when it is violoated. 

// interfaces and polymorphism 
// one interface can have multiple implementations
// Those implementations will be different implementations of the same method. 
// that is polymorphism. 
// A similar thing can be done with events and delegates but that is an advanced topic
// for example, imagine a videoencoding class that sends a notification after successful
// uploading and encoding. That notification could be  email, text, or a realtime update. 
// You make a INotificationChannel interface with a send method. Then you implement that 
// interface with an EmailNotification and a TextNotification. 
// Because you might want to have multiple notifications (text and email), VideoEncoder
// stores the interface implementations in a list
// private readonly IList<INotificationChannel> _notificationChannels; 
// The constructor for VideoEncoder initializes that private variable as an IList
// A method on VideoEncoder is how notification channel implementations are brought into
// VideoEncoder. 
// public void RegisterNotificationChannel(INotificationChannel channel){
//    _notificationChannels.Add(channel)
//}
// This is the method used at runtime to to determine with interface implementations are 
// used. 
// Notice how this will create polymorphic behavior in the method(s) inside the
// INotificationChannel interface.

            //--------------------------------------------
            //end of course 2
            //-------------------------------------------


//-------------------------------------------------------------
// Generics
// In early versions of C#, there were no generics. So, for example, in order to make a 
// list data structure that would work for all data types, you would either have to make 
// new lists for each data type you were working with, or create a list with the Object
// data type, which caused a performance penalty due to the boxing and unboxing. Generics
// solve this problem because the allow you to make data structures like lists that work 
// for all data types (you can also specify constaints so that a data stucture only works with 
// certain data types). Further, the extra work required happens at compile time, so there
// is no runtime penalty. You will almost always use the generics inside System.Collections.Generic
// so ther is no need to make your own generic data structues. However, a list would 
// look something like this. 
// public class GenericList<T>
// {// T is a convention and I believe stands for template. 
//     public void Add(T value)
//     {
//         ...
//     }
//     public T this[int index]
//     {
//         // this is an indexer and not specific to generics. 
//         get{...}
//     }
// }




        }
    }



}
