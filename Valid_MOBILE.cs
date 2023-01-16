using System;
using System.Text.RegularExpressions;

namespace day16
{
    class Program
    {
        public static string Reg_pattern1 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern3 = "^(abc)(.[A-Za-z]+)*@(bl).(co)([.][a-z]{2,})?$";  
        public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";
        public static void Main(String[] args)
        {
            Console.WriteLine("enter your First  name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your Last  name");
            string lname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your mail");
            string mail = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your mobile number");
            string mb = Console.ReadLine();
            Console.WriteLine();



            bool val1 = Regex.IsMatch(name, Reg_pattern1);
            bool val2 = Regex.IsMatch(lname, Reg_pattern2);
            bool val3 = Regex.IsMatch(mail, Reg_pattern3);
            bool val4 = Regex.IsMatch(mb, Reg_pattern4);


            if (val1)
            {
                Console.WriteLine("Pattern is correct for given First name: {0}",name);
            }
            else
                Console.WriteLine("pattern First name is wrong");
            if (val2)
            {
                Console.WriteLine("Pattern is correct for given Last name: {0}", lname);
            }
            else
                Console.WriteLine("pattern Last name is wrong");
            if (val3)
            {
                Console.WriteLine("Pattern is correct for given mail ID : {0}", mail);
            }
            else
                Console.WriteLine("pattern mail ID  is wrong");
            if (val4)
            {
                Console.WriteLine("Pattern is correct for given mobile number : {0}", mb);
            }
            else
                Console.WriteLine("pattern mobile number  is wrong");

        }
    }
}
