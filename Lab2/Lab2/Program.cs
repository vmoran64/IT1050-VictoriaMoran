using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);


            Console.WriteLine(" {0}\n{1}", "Hello World", "from Vikke");

            Console.WriteLine(" {0}\t{1}", "Hello World", "from Vikke");



            Console.ReadLine();

            //a. The point of execution is the main method. Specifically, static void Main(string[] args)
            //b. An integer stores as a whole number, while float and double store as decimals. Double stores even larger/smaller values with specificity.
            //c. A method used in cahpter 4 includes the readline method. This is a method used to retrieve and output a previously stated input. 
            //d. To read a value, we use a "Get" accessor. To assign a value, we use a "Set" accessor. 
            //e. A class is a blueprint, or a category of objects with common traits. Objects are instances of classes. You can have infinite objects per a particular class, but only one main class. 


        }
    }
}
