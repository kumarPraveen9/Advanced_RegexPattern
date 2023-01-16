using System;
using System.Text.RegularExpressions;

namespace day16
{
    class Program
    {
        public static string Reg_pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
      
        public static void Main(String[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine();
           


            bool val = Regex.IsMatch(name, Reg_pattern);
          




            if (val)
            {
                Console.WriteLine("Pattern is correct for given user name: {0}",name);
            }
            else
                Console.WriteLine("pattern is wrong");

        }
    }
}
