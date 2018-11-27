using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 Elements: public double getArea (double height, double width) {return height * width:}

            //a. Scope= public getArea
            // The scope of a method is the body of a method. It referes to the part of an application that refers to the method declared within. 
            //b. static vs non static = non static
            //This is a qualifier for type of class. A static class does not rely on external class defnition, while a non-static class allows for the user to create classes within the method. 
            //c.  return type = double
            // return type declares how the data will be returned in the program. Here, the data will be defined as double- which indicates a decimal allowed numerical value. 
            //d. Method Name = getArea
            // The method name acts as an identifer, specifying the method within the defined class.
            //e. Parameters = (double height, double width)
            // The aprameters of a method indicate what inputs must be entered in order for the method to perform its function. Here, width and height must be entered or the method cannnot complete
            //f. Method Body = {return height * width:}
            // the body of the method is what determines the action of the method. Here, the point of the method is to multiply height and width. This multiplication happens here.

            //3 User defined method
            // One of the huge strengths of C# is its large library of method frameworks- the .NET library. With this library, a user does not have to predefine every method they need, rather, they can use methodolgy already in existance.
            // A user defined method is just that- one where the user has to define parameters, return type, and function. It is more time consuming, but allows a user to customize methods based on needs, and to reuse them as needed. 
            // When defining a method, a user should consider their ability for reuse, making them as non=specific as possible. When possible, a user should limit self-defined methods and explore existing methods in .NET.

            //4 Static vs Non static
            // A static method is one that does not depend upon an object to do its job. Additionally, it will only apply to the class where it has been declared.
            // non-static Methods are those that rely upon a predefined object. They can also exist outside the scope of the class they are declared in. 

            //5 cs.dog- copied code below, dog.cs also pushed to repo

            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;

namespace Dog
    {
        class Dog
        {
            public string Name { get; set; }

            // Add bark() method

            public void bark()
            {
                Console.Writeline("{0} is Barking...", name);
            }


            // Add doTrick() method

            public void doTrick(string trickName)
            {
                Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", name, trickName);
            }

        }
    }



}
    }
}
