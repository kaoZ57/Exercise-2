using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cash = 100;
            int seclct;
        UP:
            Console.WriteLine("=======");
            Console.WriteLine("Account");
            Console.WriteLine("=======");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("0. Exit");
            Console.Write("Select number : ");

            try
            {
                seclct = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                goto UP;
            }

            if (seclct == 1)//Deposit
            {
                Console.Write("Enter money to deposit : ");
                cash += Int32.Parse(Console.ReadLine());
                Console.WriteLine("Account balance " + cash);
                goto UP;
            }
            if (seclct == 2)//Withdraw
            {
                Console.Write("Enter money to withdraw : ");
                int inputCash = Int32.Parse(Console.ReadLine());
                if (inputCash > cash)
                {
                    Console.WriteLine("Canont withdraw becourse money will less " + cash);
                    goto UP;
                }
                else
                {
                    cash -= inputCash;
                    Console.WriteLine("Account balance " + cash);
                    goto UP;
                }
            }
            if (seclct == 3)//Check Balance
            {
                Console.WriteLine("have money : " + cash);
                goto UP;
            }
            if (seclct == 0)//Exit
            {
                Environment.Exit(0);
            }

        }
    }
}
