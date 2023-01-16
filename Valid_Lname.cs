using System;
using System.Text.RegularExpressions;

namespace day16
{
    class Program
    {
        public static string Reg_pattern1 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static void Main(String[] args)
        {
            Console.WriteLine("enter your First name name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your Last name name");
            string lname = Console.ReadLine();
            Console.WriteLine();



            bool val1 = Regex.IsMatch(name, Reg_pattern1);
            bool val2 = Regex.IsMatch(lname, Reg_pattern2);




            if (val1)
            {
                Console.WriteLine("Pattern is correct for given First name: {0}",name);
            }
            else
                Console.WriteLine("pattern is wrong");
            if (val2)
            {
                Console.WriteLine("Pattern is correct for given Last name: {0}", lname);
            }
            else
                Console.WriteLine("pattern is wrong");

        }
    }
}
