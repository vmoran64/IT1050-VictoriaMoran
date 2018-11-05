using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4test
{
    class Account
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is: {myAccount.Getname()}");

            Console.Write("Enter the name: ");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);

            Console.WriteLine($"myAccount's name is {myAccount.Getname()}");

    }
}
