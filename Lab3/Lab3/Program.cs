using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. If provides a flowchart method of options- If one condition is fullfilled this,
            // other wise this, and so on. While acts as a loop. Every action changes the subject,
            // the program continues to act until outside of the action parameters.
            {
                //3
                int speedlimit;
                int speed;

                speedlimit = 35;
                speed = 42;

                if (speed > speedlimit)
                    Console.WriteLine("SLOW DOWN!");
            }
            {
                //4
                int istrue = 5;

                Console.WriteLine("Enter your number");
                int meow = Convert.ToInt32(Console.ReadLine());

                if (istrue != meow)
                    Console.WriteLine("It is false!!!!!");

                else

                    Console.WriteLine("It is true!!!");
                    
                
            }


            {
                // 5
                double FInput;
                double COutput;

                Console.WriteLine("Enter Fahrenheit");
                FInput = Convert.ToDouble(Console.ReadLine());

                COutput = ((FInput - 32d) * 5d / 9d);
                Console.WriteLine("The temp in Celcius is ");
                Console.WriteLine(COutput);

                if (FInput < 40)
                    Console.WriteLine("It is cold!");

                else
                if (FInput > 90)
                     Console.WriteLine("It is hot!");

                else
                Console.WriteLine("It is just right!");
            }


            {
            // 6-8
            int value = 1;
                while (value < 11)
                    { Console.WriteLine(value); 
                    value = value += 1; }
                    }

            int value2 = 60;
                while (value2 >19)
                     { Console.WriteLine(value2);
                    value2 = value2 -= 5;
                     }

            int value3 = 10;
                 while (value3 < 21)
                     { Console.WriteLine(value3);
                      value3 = value3 += 2;
                      }

            Console.ReadKey();
        }
    }
}
