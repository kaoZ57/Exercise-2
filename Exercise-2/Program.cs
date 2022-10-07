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

            Console.WriteLine("Account");
            Console.WriteLine("=======");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("0. Exit");
            Console.Write("Select number : ");
        UP:
            try
            {
                seclct = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                goto UP;
            }

            if (seclct == 1)
            {

            }
            if (seclct == 2)
            {

            }
            if (seclct == 3)
            {

            }
            if (seclct == 0)
            {

            }

        }
    }
}
