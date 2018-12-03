using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. The array access expressions to access each of the elements in p are p[0], p[1], p[2], p[3].

            //3.
            {
                string[] months;
                months = new string[12];

                months[0] = "Jan";
                months[1] = "Feb";
                months[2] = "Mar";
                months[3] = "Apr";
                months[4] = "May";
                months[5] = "Jun";
                months[6] = "Jul";
                months[7] = "Aug";
                months[8] = "Sep";
                months[9] = "Oct";
                months[10] = "Nov";
                months[11] = "Dec";

                for (int counter = 0; counter < 12; ++counter)

                    Console.WriteLine(months[counter]);

                Console.ReadKey();
            }

            //4.

            {
                string[] seasons;
                seasons = new string[4];

                seasons[0] = "Winter";
                seasons[1] = "Spring";
                seasons[2] = "Summer";
                seasons[3] = "Fall";

                foreach (string season in seasons)
                    Console.WriteLine(season);

                Console.ReadKey();
            }

            //5. 
            {
                int[] rando;
                rando = new int[1000];

                Random random = new Random();

                for (int counter = 0; counter < rando.Length; counter++)
                {
                    rando[counter] = random.Next(0, 1000);
                }
                foreach (int number in rando)
                    Console.WriteLine(number);

                Console.ReadKey();

            }

            //6. 

            {
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                int i = 0;
                while (i < names.Length)
                {
                    Console.WriteLine(names[i]);
                    i++;

                    Console.ReadKey();
                }
            }

            //7. 
            {
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                int x = 0;
                while (x < names.Length)
                {
                    Console.WriteLine("{0,2}. {1}", x, names[x]);
                    x++;

                    Console.ReadKey();
                }
            }

            //8. 
            {
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                foreach (string name in names)
                    Console.WriteLine(name);

                Console.ReadKey();
            }
        }
    }
}
    

