using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. The four basic elements of counter controlled repetition are:
                //variable- acts as the counter
                // initial value - this is what the variable is set to. It determines the starting point for the counter
                // increment/ decrement- controls how much is added, taken away from the counter each loop
                // condition- what the program is supposed to do each iteration. Also determines if looping should end.

            // 3. While and for have simillar uses but are ultimately different. 
                // For usually terminates at a sentinal value; this means there is a predetermined stop point for the loop
                // While stops only when a condition is met.

            // 4. Do-while can be advantageously used over while statements. The biggest difference is that while evaluates 
            //at the beginning of a loop, while do-while evaluates at the end. Do-while will always execute at least once, making it 
            // valuable for any program where you need at least one iteration. This is useful for asking a user input. Since the validation 
            // occurs at the end of the loop, any discrepancy would be identified right away rather than prompting a 
            //user over and over to reinput. 


            // 5. complete

            {
                int i = 1;


                for (i = 1; i <= 100; ++i)
                   
                {
                    if ((i % 2) == 0 ) { Console.WriteLine("{0} ", i); Console.WriteLine("is even"); }

                    else

                    { Console.WriteLine("{0} ", i); Console.WriteLine("is odd"); }

                }

                //6. complete
                {
                    Console.WriteLine("Please enter a temperature...");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input < 10) Console.WriteLine("Polar Bear");
                    else
                    if (input < 20) Console.WriteLine("Penguin");
                    else
                    if (input < 40) Console.WriteLine("Moose");
                    else
                    if (input < 50) Console.WriteLine("Reindeer");
                    else
                    if (input < 60) Console.WriteLine("Deer");
                    else
                    if (input < 70) Console.WriteLine("Turtle");
                    else
                    if (input < 80) Console.WriteLine("Lion");
                    else
                    if (input < 90) Console.WriteLine("Fish");
                    else
                        Console.WriteLine("Bug");
                }

            // 7. There is no increaser in this code. Add increaser to fix. 
            //also had to change interger, I used "i" elsewhere. 
            {
                    int y = 10;
                      while (y < 21)
                    { 
                            Console.WriteLine(y);
                        y++;
                    }
                    
                                   }

                //8. Complete
                //Added brackets around loop body (Also changed variable to y)
            {
                    for (int x = 0; x < 101; x++)
                    {
                        Console.WriteLine(x);
                        Console.WriteLine("********");
                    }


                }


                Console.ReadKey();

            }
        }
    }
}
