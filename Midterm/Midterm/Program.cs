using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. 3 types of control structures
            //a. Sequential: this mode reads and executes code line by line, this is the default.
            //b. Selction: This structure is used for decison making, where branch choice is selected based on the set paparmeters. Includes if/else and switch.
            //c.Repetition: This structure is used for looping, when a command set is executed mutiple times. Includes while and for. 

            { //3.
                // bool keepLooping = true;
                // int counter = 1;


                //  while (keepLooping == true)
                // { Console.WriteLine(counter); counter++; }
            }

            //4. 
            {
                int loop = 2;
                while (loop <= 128)
                {
                    Console.WriteLine($"[{loop}]");
                    loop = loop * 2;
                }
                Console.ReadKey();
            }
            //5.
            int countdown = 49;
            for (countdown = 49; countdown > 0; countdown--)
            {
                Console.Write(countdown);
                if
                    (countdown > 1)
                    Console.Write(",");

            }
            Console.ReadKey();

            Console.WriteLine();

            //6. 
            int countup = 1;

            while (countup < 22)

            {
                Console.Write(countup);
                countup = countup + 2;
                if (countup < 22)
                    Console.Write(" ");
            }


            Console.ReadKey();

            //7. The ouput for the bolow code is an asterisk. The program will run through one iteration (printing the asterisk) before the test condition (i <n) fails to be true, then program will terminate.

            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition
            Console.ReadKey();

            // With a while statement, there will be the same output. Here, the program checks the condition before executing the main body. Since the parameter is false, the progrsm terminates imidiately (Empty console window)
            int o = 8;
            int j = 10;
            while (j < o) ; // test condition

            {
                Console.WriteLine("*");
                i++; // update!}

                Console.ReadKey();
            }

            //8 
            // Booleans can be combined in the following ways:
            // AND (&) operator- Returns true if both conditions are true (returns false if either is false)
            // OR (|) operator- returns true if any conditions are true (false if all are false)
            // Xor (^) operator- returns true if only one condition is true (false if all false or if all true)


            Boolean icyRain = false;
            Boolean tornadoWarning = false;

            if (!(icyRain | tornadoWarning))
            {
                Console.WriteLine("Let's go outside!");
            }
            Console.ReadKey();

            //9 

            int v = 1;

            while (v < 6)

            {      if (v < 2)
                    Console.WriteLine("123454321");
                else
                if (v < 3)
                    Console.WriteLine(" 1234321");
                else
                if (v < 4)
                    Console.WriteLine("  12321");
                else
                if (v < 5)
                    Console.WriteLine("   121");
                else
                if (v < 6)
                    Console.WriteLine("    1");

            v++;
                        }

            Console.ReadKey();



        }
    }
}
        
    

