using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace day16
{
   
    class Program
    {
       
        public static void Main(String[] args)
        {
            Console.WriteLine("enter your First  name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your Last  name");
            string lname = Console.ReadLine();
            Console.WriteLine();
          
            Console.WriteLine("enter HOW many emails u want to validate");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter your mail");
                string mail = Console.ReadLine();
                demo d1=new demo();
                try
                {
                    d1.validmail(mail);
                }
                catch (InvalidException e)
                {
                    Console.WriteLine("Oops {0} ! ", e.Message);
                }
            }
            Console.WriteLine();


            Console.WriteLine("enter your mobile number");
            string mb = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your password ");
            string pwd = Console.ReadLine();
            Console.WriteLine();

            demo d = new demo();
            try
            {
                d.validname(name);
            }
            catch (InvalidException e)
            {
                Console.WriteLine("Oops {0} ! ", e.Message);
            }

            try
            {
                d.validname(lname);
            }
            catch (InvalidException e)
            {
                Console.WriteLine("Oops {0} ! ", e.Message);
            }

            try
            {
                d.validname(mb);
            }
            catch (InvalidException e)
            {
                Console.WriteLine("Oops {0} ! ", e.Message);
            }

            try
            {
                d.validname(pwd);
            }
            catch (InvalidException e)
            {
                Console.WriteLine("Oops {0} ! ", e.Message);
            }
        }
    }


   
    public class demo
    {

        public Regex Reg_pattern1 = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex Reg_pattern2 = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex Reg_pattern3 = new Regex(@"^[A-Za-z0-9]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");
        public Regex Reg_pattern4 = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex Reg_pattern5 = new Regex(@"^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$");
        public Regex Reg_pattern5_1 = new Regex(@"^[a-zA-Z]{8,}([0-9]+)?$");
        public Regex Reg_pattern5_2 = new Regex(@"^[A-Z]{1,}[a-zA-Z]{7,}([0-9]+)?$");
        public Regex Reg_pattern5_3 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}([0-9]+)?$");
        





        public string validname(string name) => Reg_pattern1.IsMatch(name) ? "First Name is valid" :
            throw new InvalidException("invalid first name");


        public string validlname(string lname) => Reg_pattern2.IsMatch(lname) ? "last Name is valid" :
           throw new InvalidException("invalid last name");

        public string validmail(string mail) => Reg_pattern3.IsMatch(mail) ? "mail is valid" :
          throw new InvalidException("invalid mail");

        public string validmobile(string mb) => Reg_pattern4.IsMatch(mb) ? "mobile is valid" :
         throw new InvalidException("invalid mobile");

        public string validpwd(string pwd) => Reg_pattern5.IsMatch(pwd) ? "password is valid" :
        throw new InvalidException("invalid password");

        public string validpwd1(string pwd) => Reg_pattern5_1.IsMatch(pwd) ? "password is valid" :
       throw new InvalidException("invalid password");

        public string validpwd2(string pwd) => Reg_pattern5_2.IsMatch(pwd) ? "password is valid" :
       throw new InvalidException("invalid password");

        public string validpwd3(string pwd) => Reg_pattern5_3.IsMatch(pwd) ? "password is valid" :
       throw new InvalidException("invalid password");


       
           


    }
    
}

